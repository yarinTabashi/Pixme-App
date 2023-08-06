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
using Java.Lang;

namespace PixmeApp
{
    public class ViewHolder : Java.Lang.Object
    {
        public TextView eventNameTxv { get; set; }
        public TextView eventDiscTxv { get; set; }
        public TextView eventDateTxv { get; set; }
        public TextView eventMoreDaysTxv { get; set; }
    }
}