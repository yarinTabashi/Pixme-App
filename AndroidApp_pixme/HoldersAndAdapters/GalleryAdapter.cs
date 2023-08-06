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
using Android.Support.V4.App;
using Android.Support.V4.View;
using Java.Lang;

namespace PixmeApp
{
    public class GalleryAdapter : PagerAdapter
    {
        private readonly Context context;
        private List<string> pictures;

        public GalleryAdapter(Context context, List<string> pictures)
        {
            this.context = context;
            this.pictures = pictures;
        }

        public override int Count
        {
            get
            {
                return pictures.Count;
            }
        }

        public override bool IsViewFromObject(View view, Java.Lang.Object objectValue)
        {
            return view == ((ImageView)objectValue);
        }

        public override Java.Lang.Object InstantiateItem(View container, int position)
        {
            string picture = pictures[position];

            ImageView imageView = new ImageView(context);
            imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
            imageView.SetImageBitmap(Converting.Convert(picture));
            ((ViewPager)container).AddView(imageView, 0);
            return imageView;
        }

        public override void DestroyItem(View container, int position, Java.Lang.Object objectValue)
        {
            ((ViewPager)container).RemoveView((ImageView)objectValue);
        }
    }
}