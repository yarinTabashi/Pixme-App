using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using BLFinalPro;

namespace PixmeApp
{
    public class SelectInvitesFrg : Fragment
    {
        private ListView lstvFriends = null;
        private List<string> friendsNames = null;
        private List<int> friendsIds = null;
        private List<int> friendsClientInvited = null;
        private Client theClient = null;
        private int clientId = 0;
        private Button addFriendsBtn;
        private Bundle bundle = null;
        private int eventId = 0;
        private Event theEvent = null;
        private bool alreadyInvited = false;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            this.lstvFriends = view.FindViewById<ListView>(Resource.Id.lstv_friends);
            this.addFriendsBtn = view.FindViewById<Button>(Resource.Id.search_new_friends_btn);

            addFriendsBtn.Click += (sender, e) =>
            {
                this.bundle = new Bundle();
                this.bundle.PutInt("clientId", this.clientId);

                Fragment searchFriendsFrg = new SearchNewFriendsFrg();
                searchFriendsFrg.Arguments = this.bundle;
                FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, searchFriendsFrg).Commit();
            };

            this.friendsNames = new List<string>();

            this.theClient = new Client();
            theClient.SignInById(clientId);

            Client bestFriendClient = new Client();
            bestFriendClient.SignInById(theClient.GetBestFriend());
            string textForToast = "Don't forget invite ";
            textForToast += bestFriendClient.GetFullName();
            textForToast += ". I think is your best friend!";
            Toast.MakeText(Activity, textForToast, ToastLength.Long).Show();

            this.friendsIds = theClient.GetAllClientFriendsIDs();
            this.friendsNames = theClient.GetAllClientFriendsNames();
            this.friendsClientInvited = new List<int>();

            this.theEvent = new Event(this.eventId);
            this.theEvent.InviteMember(this.clientId);

            lstvFriends.Adapter = new CustomFriendAdapter(friendsNames);
            lstvFriends.ItemClick += LstvFriends_ItemClick;
        }

        private void LstvFriends_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            for (int i = 0; (i < this.friendsClientInvited.Count) && (!alreadyInvited); i++)
            {
                if (this.friendsClientInvited[i] == friendsIds[e.Position])
                {
                    Toast.MakeText(Activity, "You already invited this friend!", ToastLength.Long).Show();
                    this.alreadyInvited = true;
                }
            }

            if (!alreadyInvited)
            {
                this.theEvent.InviteMember(friendsIds[e.Position]);
                this.friendsClientInvited.Add(friendsIds[e.Position]);
                Toast.MakeText(Activity, "Added successfully!", ToastLength.Long).Show();
            }
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Bundle bundle = Arguments;
            this.clientId = bundle.GetInt("clientId", 0);
            this.eventId = bundle.GetInt("eventId", 0);

            View view = inflater.Inflate(Resource.Layout.my_friends_layout, container, false);
            return view;
        }
    }
}