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
    public class MyFriendsFrg : Fragment
    {
        private ListView lstvFriends = null;
        private List<string> friendsNames = null;
        private List<int> friendsIds = null;
        private Client theClient = null;
        private int clientId = 0;
        private Button addFriendsBtn;
        private Bundle bundle = null;

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

            this.friendsIds = theClient.GetAllClientFriendsIDs();
            this.friendsNames = theClient.GetAllClientFriendsNames();

            lstvFriends.Adapter = new CustomFriendAdapter(friendsNames);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Bundle bundle = Arguments;
            this.clientId = bundle.GetInt("clientId", 0);

            View view = inflater.Inflate(Resource.Layout.my_friends_layout, container, false);
            return view;
        }
    }
}