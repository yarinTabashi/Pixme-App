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
using Android.Support.V4.View;
using BLFinalPro;

namespace PixmeApp
{
    public class UpcomingEventsFragment : Fragment
    {
        private int clientId = 0;
        private Client client = null;

        private List<int> eventsIdLst = null;
        private List<Event> eventsLst = null;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            this.eventsIdLst = new List<int>();
            this.eventsLst = new List<Event>();

            ListView lsv = view.FindViewById<ListView>(Resource.Id.lstvv);

            client = new Client();
            client.SignInById(this.clientId);

            eventsIdLst = client.GetAllIdCloseEvents();

            if (eventsIdLst == null)
            {
                eventsIdLst = new List<int>();
            }

            for(int i = 0; i < eventsIdLst.Count; i++)
            {
                eventsLst.Add(new Event(eventsIdLst[i]));
            }

            lsv.Adapter = new CustomAdapterEvent(eventsLst);
            lsv.ItemClick += (sender, e) =>
            {
                Bundle bundle = new Bundle();
                bundle.PutInt("clientId", this.clientId);
                bundle.PutInt("eventId", eventsIdLst[e.Position]);

                Fragment detailsFrg = new EventDetailsFrg();
                detailsFrg.Arguments = bundle;
                FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, detailsFrg).Commit();
            };
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Bundle bundle = Arguments;
            this.clientId = bundle.GetInt("clientId", 0);

            View view = inflater.Inflate(Resource.Layout.fragment_event, container, false);
            return view;
        }
    }
}