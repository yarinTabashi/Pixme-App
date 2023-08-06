using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using static Android.Support.V7.Widget.RecyclerView;
using Java.Lang;
using BLFinalPro;

namespace PixmeApp
{
    public class CustomAdapterEvent : BaseAdapter<Event>
    {
        List<Event> events;
        
        public CustomAdapterEvent(List<Event> events)
        {
            this.events = events;
        }

        public override Event this[int position]
        {
            get
            {
                return events[position];
            }
        }

        public override int Count
        {
            get
            {
                return events.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.item_event, parent, false);

                TextView eventName = view.FindViewById<TextView>(Resource.Id.nameeventxt);
                TextView eventDate = view.FindViewById<TextView>(Resource.Id.datetxtv);
                TextView eventDesc = view.FindViewById<TextView>(Resource.Id.descriptiontxtv);
                TextView counterMoreDays = view.FindViewById<TextView>(Resource.Id.counter_more_daystxtv);

                view.Tag = new ViewHolder() { eventNameTxv = eventName, eventDiscTxv = eventDesc, eventDateTxv = eventDate, eventMoreDaysTxv= counterMoreDays} ;
            }

            ViewHolder holder = (ViewHolder)view.Tag;

            holder.eventNameTxv.Text = events[position].GetEventName();
            holder.eventDiscTxv.Text = events[position].GetEventDescription();
            holder.eventDateTxv.Text = events[position].GetEventDate().ToString();
            holder.eventMoreDaysTxv.Text = events[position].GetDaysLeft().ToString();
            return view;         
        }
    }
}
