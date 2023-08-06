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
    public class EventDetailsFrg : Fragment
    {
        private Event theEvent = null;
        private int clientId = 0;
        private int eventId = 0;

        private TextView nameTxv;
        private TextView descriptionTxv;
        private TextView moreDaysTxv;
        private TextView dateTxv;
        private Button allowBtn;
        private Button denyBtn;
        private CheckBox hideCbx;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            // Create your application here
            this.nameTxv = view.FindViewById<TextView>(Resource.Id.eventnametxv);
            this.descriptionTxv = view.FindViewById<TextView>(Resource.Id.desctxv);
            this.moreDaysTxv = view.FindViewById<TextView>(Resource.Id.moredaystxv);
            this.dateTxv = view.FindViewById<TextView>(Resource.Id.datetxv);
            this.allowBtn = view.FindViewById<Button>(Resource.Id.allowbtn);
            this.denyBtn = view.FindViewById<Button>(Resource.Id.denybtn);
            this.hideCbx = view.FindViewById<CheckBox>(Resource.Id.hidecbx);


            Event theEvent = new Event(this.eventId);
            this.nameTxv.Text = theEvent.GetEventName();
            this.descriptionTxv.Text = theEvent.GetEventDescription();
            this.dateTxv.Text = theEvent.GetEventDate().ToString("dd/MM/yyyy");
            this.moreDaysTxv.Text = theEvent.GetDaysLeft().ToString() + " days left!";

            Client theClient = new Client();
            theClient.SignInById(this.clientId);

            allowBtn.Click += (sender, e) =>
            {
                if (hideCbx.Checked)
                {
                    theClient.ArrivalConfirmation(this.eventId, "Hide");// לא מעוניין שיצלמו אותי
                    Toast.MakeText(Activity, "Thanks. We will hide you.", ToastLength.Long).Show();
                }
                else
                {
                    theClient.ArrivalConfirmation(this.eventId, "Show");
                    Toast.MakeText(Activity, "Thanks. Enjoy.", ToastLength.Long).Show();
                }
            };

            denyBtn.Click += (sender, e) =>
            {
                theClient.ArrivalDeny(this.eventId, "No");
                Toast.MakeText(Activity, "Thanks. We would be happy you would join.", ToastLength.Long).Show();
            };
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Bundle bundle = Arguments;
            this.clientId = bundle.GetInt("clientId", 0);
            this.eventId = bundle.GetInt("eventId", 0);

            View view = inflater.Inflate(Resource.Layout.event_details_frg, container, false);
            return view;
        }
    }
}