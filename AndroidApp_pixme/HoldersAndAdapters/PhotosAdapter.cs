using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Net;
using Java.Lang;

namespace PixmeApp
{
    public class PhotosAdapter : BaseAdapter<string>
    {
        private List<string> pictures;

        public PhotosAdapter(List<string> pictures)
        {
            this.pictures = pictures;
        }

        public override string this[int position]
        {
            get
            {
                return pictures[position];
            }
        }

        public override int Count
        {
            get
            {
                return pictures.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            string picture = pictures[position];
            ImageView imageView;

            var view = convertView;

            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.item_photo, parent, false);

                imageView = view.FindViewById<ImageView>(Resource.Id.img);
                imageView.SetImageBitmap(Converting.Convert(picture));
                view.Tag = new CustomAdapterViewHolderGal() {imageView = imageView };
            }

            return view;
        }
    }
}