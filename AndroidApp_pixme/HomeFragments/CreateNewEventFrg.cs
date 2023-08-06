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
    public class CreateNewEventFrg : Fragment
    {
        private int clientId = 0;
        private EditText eventNameDt;
        private EditText eventDescDt;
        private EditText eventType;
        private CheckBox isNeedPhotographerCbx;
        private Button pickADateBtn;
        private Button createBtn;
        private int isNeedPhotogorapher = 0;
        private Client theClient = new Client();
        private Event theNewEvent = null;
        
        private DateTime tempDate;
        private int suggestPhotographer = 0;
        private string choseDate = "";

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }


        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            // Create your application here
            this.eventNameDt = view.FindViewById<EditText>(Resource.Id.namedt);
            this.eventDescDt = view.FindViewById<EditText>(Resource.Id.descdt);
            this.eventType = view.FindViewById<EditText>(Resource.Id.eventtype);
            this.isNeedPhotographerCbx = view.FindViewById<CheckBox>(Resource.Id.needphotogcbx);
            this.createBtn = view.FindViewById<Button>(Resource.Id.createbtn);
            this.pickADateBtn = view.FindViewById<Button>(Resource.Id.taking_new_pic_btn);

            int theType = 0;
            createBtn.Click += (sender, e) =>
            {
                //this.tempDate = DateTime.ParseExact(this.choseDate, "dd/M/yyyy", null);
                try
                {
                    theType = int.Parse(this.eventType.Text.ToString());
                }
                catch
                {
                    theType = 1;
                }
                if (isNeedPhotographerCbx.Checked)
                {
                    this.theNewEvent = new Event(this.clientId, 1, this.eventNameDt.Text, this.eventDescDt.Text, this.choseDate, theType);
                    this.suggestPhotographer = this.theNewEvent.SuggestAvailablePhotographer();

                    Bundle bundle = new Bundle();
                    bundle.PutInt("eventId", this.theNewEvent.GetEventId());
                    bundle.PutInt("photographerId", this.suggestPhotographer);
                    bundle.PutInt("clientId", this.clientId);

                    Fragment photographerActivity = new PhotographerActivity();
                    photographerActivity.Arguments = bundle;
                    FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, photographerActivity).Commit();
                }
                else
                {
                    this.theNewEvent = new Event(this.clientId, 0, this.eventNameDt.Text, this.eventDescDt.Text, this.choseDate, int.Parse(this.eventType.Text.ToString()));


                    Bundle bn = new Bundle();
                    bn.PutInt("eventId", this.theNewEvent.GetEventId());
                    bn.PutInt("photographerId", this.suggestPhotographer);
                    bn.PutInt("clientId", this.clientId);
                    Fragment searchFriendsFrg = new SelectInvitesFrg();
                    searchFriendsFrg.Arguments = bn;
                    FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, searchFriendsFrg).Commit();

                }
            };
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Bundle bundle = Arguments;
            this.clientId = bundle.GetInt("clientId", 0);
            this.choseDate = bundle.GetString("choseDate", "");

            View view = inflater.Inflate(Resource.Layout.create_new_event, container, false);
            return view;
        }
    }
}