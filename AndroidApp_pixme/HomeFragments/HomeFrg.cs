using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using BLFinalPro;

namespace PixmeApp
{
    public class HomeFrg : Fragment
    {
        private int clientId = 0;
        private Client client = null;
        private int liveEventId = 0;
        private TextView helloTxt = null;
        private TextView totalCounterTxv = null;
        private ListView liveEventsLstv = null;
        private List<Event> eventsLst = null;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            this.helloTxt = view.FindViewById<TextView>(Resource.Id.client_name_live_events);
            this.liveEventsLstv = view.FindViewById<ListView>(Resource.Id.lstv_live_events);
            this.totalCounterTxv = view.FindViewById<TextView>(Resource.Id.total_counter_txv);

            this.client = new Client();
            this.client.SignInById(this.clientId);

            this.helloTxt.Text = this.client.GetFirstName();
            this.totalCounterTxv.Text = this.client.GetCounterEventsParticipate() + " Mine";
            this.liveEventId = this.client.GetIdLiveEvent();

            if (liveEventId != 0)
            { 
                this.eventsLst = new List<Event>();
                eventsLst.Add(new Event(this.liveEventId));
                liveEventsLstv.Adapter = new CustomAdapterEvent(eventsLst);
                liveEventsLstv.ItemClick += (sender, e) =>
                {
                    Bundle bundle = new Bundle();
                    bundle.PutInt("clientId", this.clientId);
                    bundle.PutInt("eventId", this.liveEventId);

                    Fragment eventRoomFrg = new EventRoomFrg();
                    eventRoomFrg.Arguments = bundle;
                    FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, eventRoomFrg).Commit();
                };
            }
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Bundle bundle = Arguments;
            this.clientId = bundle.GetInt("clientId", 0);

            View view = inflater.Inflate(Resource.Layout.homefrgm, container, false);
            return view;
        }
    }
}