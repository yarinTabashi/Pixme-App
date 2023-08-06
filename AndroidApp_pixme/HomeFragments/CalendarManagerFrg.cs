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
    public class CalendarManagerFrg : Fragment
    {
        private int clientId = 0;
        private Client theClient = null;
        private CalendarView calend = null;
        private TextView chosedDateTxv = null;
        private Button buttonChosed = null;
        private string choseDate = "";
        private DateTime tempDate;

        private List<int> eventsIds = null;
        private List<string> eventNames = null;
        private List<DateTime> eventsDates = null;
        private Event tempEvent = null;
        private bool foundEvent = false;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            this.calend = view.FindViewById<CalendarView>(Resource.Id.calendarView1);
            this.chosedDateTxv = view.FindViewById<TextView>(Resource.Id.date_txv);
            this.buttonChosed = view.FindViewById<Button>(Resource.Id.chosed_date_btn);
            this.buttonChosed.Enabled = false;

            this.theClient = new Client();
            theClient.SignInById(this.clientId);
            this.eventsIds = theClient.GetAllIdEvents();

            this.eventNames = new List<string>();
            this.eventsDates = new List<DateTime>();
            
            for (int i = 0; i < this.eventsIds.Count; i++)
            {
                this.tempEvent = new Event(this.eventsIds[i]);
                this.eventNames.Add(this.tempEvent.GetEventName());
                this.eventsDates.Add(this.tempEvent.GetEventDate());
            }

            calend.DateChange += Calend_DateChange;
        }

        private void Calend_DateChange(object sender, CalendarView.DateChangeEventArgs e)
        {
            foundEvent = false;

            this.tempDate = new DateTime(e.Year, e.Month + 1, e.DayOfMonth);
            this.choseDate = this.tempDate.ToString("dd/MM/yyyy");

            for (int i = 0; i < eventsDates.Count; i++)
            {
                if ((eventsDates[i].Year ==  this.tempDate.Year) && (eventsDates[i].Month ==  this.tempDate.Month) && (eventsDates[i].Day == this.tempDate.Day))
                {
                    this.chosedDateTxv.Text =  "Event name: " + eventNames[i].ToString();
                    foundEvent = true;
                }
            }
            
            if (!foundEvent)
            {
                this.chosedDateTxv.Text = "Still there is no event on the date";
            }

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Bundle bundle = Arguments;
            this.clientId = bundle.GetInt("clientId", 0);

            View view = inflater.Inflate(Resource.Layout.calendar_layout, container, false);
            return view;
        }
    }
}