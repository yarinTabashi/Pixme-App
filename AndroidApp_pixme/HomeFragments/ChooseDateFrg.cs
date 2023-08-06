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

namespace PixmeApp
{
    public class ChooseDateFrg : Fragment
    {
        private int clientId = 0;
        private int tempClientFriend = 0;
        private CalendarView calend = null;
        private TextView chosedDateTxv = null;
        private Button buttonChosed = null;
        private string choseDate = "";
        private Bundle bundleToSend = null;
        private DateTime tempDate;

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

            calend.DateChange += Calend_DateChange;
            this.buttonChosed.Click += ButtonChosed_Click;
        }

        private void ButtonChosed_Click(object sender, EventArgs e)
        {
            bundleToSend = new Bundle();
            bundleToSend.PutInt("clientId", this.clientId);
            bundleToSend.PutString("choseDate", this.choseDate);

            Fragment createNewEventFrg = new CreateNewEventFrg();
            createNewEventFrg.Arguments = bundleToSend;
            FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, createNewEventFrg).Commit();
        }

        private void Calend_DateChange(object sender, CalendarView.DateChangeEventArgs e)
        {
            this.buttonChosed.Enabled = true;
            this.tempDate = new DateTime(e.Year, e.Month + 1, e.DayOfMonth);
            this.choseDate = this.tempDate.ToString("dd/M/yyyy");
            this.chosedDateTxv.Text = "The date is: " + this.choseDate.ToString();
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