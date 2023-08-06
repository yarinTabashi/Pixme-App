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
    public class ImageDetailsFrg : Fragment
    {
        private string imagePath = "";
        private List<string> participantsImage = null;
        private Picture pic = null;
        private ImageView imageView = null;
        private TextView txt = null;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            this.imageView = view.FindViewById<ImageView>(Resource.Id.image_view_details);
            this.txt = view.FindViewById<TextView>(Resource.Id.particpants_textview_details);

            this.imageView.SetImageBitmap(Converting.Convert(this.imagePath));
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Bundle bundle = Arguments;
            this.imagePath = bundle.GetString("imagePath", "");

            View view = inflater.Inflate(Resource.Layout.homefrgm, container, false);
            return view;
        }
    }
}