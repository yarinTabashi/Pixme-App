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
using System.Collections;

namespace PixmeApp
{
    public class SearchNewFriendsFrg : Fragment
    {
        private ListView lstvFriends = null;
        private List<string> friendsNames = null;
        private List<int> friendsIds = null;
        private Client theClient = null;
        private int clientId = 0;
        private int tempClientFriend= 0;
        private CustomFriendAdapter adapt = null;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            this.lstvFriends = view.FindViewById<ListView>(Resource.Id.lstv_search_friends);

            this.friendsNames = new List<string>();

            this.theClient = new Client();
            theClient.SignInById(clientId);

            this.friendsIds = theClient.GetAllClientsIds();
            this.friendsNames = theClient.GetAllClientsNames();

            this.adapt = new CustomFriendAdapter(friendsNames);
            lstvFriends.Adapter = this.adapt;
            lstvFriends.ItemClick += LstvFriends_ItemClick;
        }

        private void LstvFriends_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            this.tempClientFriend = friendsIds[e.Position];
            if (tempClientFriend != 0)
            {
                if (this.theClient.ClientsAreFriends(this.tempClientFriend))
                {
                    Toast.MakeText(Activity, "You're already friends" , ToastLength.Long).Show();
                }
                else
                {
                    this.theClient.AddNewFriends(this.tempClientFriend);
                    Toast.MakeText(Activity, "Added successfully.", ToastLength.Short).Show();
                }
            }
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Bundle bundle = Arguments;
            this.clientId = bundle.GetInt("clientId", 0);

            View view = inflater.Inflate(Resource.Layout.search_friends_layout, container, false);
            return view;
        }
    }
}