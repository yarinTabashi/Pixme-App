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

namespace PixmeApp
{
    public class CustomFriendAdapter : BaseAdapter<string>
    {
        private List<string> friendsNames = null;

        public CustomFriendAdapter(List<string> friendsNames)
        {
            this.friendsNames = friendsNames;
        }

        public override string this[int position]
        {
            get
            {
                return friendsNames[position];
            }
        }

        public override int Count
        {
            get
            {
                return friendsNames.Count;
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
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.friend_item, parent, false);

                TextView friendNameTxv = view.FindViewById<TextView>(Resource.Id.friend_name_txtv);
                friendNameTxv.Text = friendsNames[position];
            };
            return view;
        }
    }
}