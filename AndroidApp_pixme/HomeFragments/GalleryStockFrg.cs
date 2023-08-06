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
using Android.Support.V7.Widget;

namespace PixmeApp
{
    public class GalleryStockFrg : Fragment
    {
        private int clientId = 0;
        private int eventId = 0;
        private Event theEvent = null;
        private Picture pic = null;
        private List<string> allPaths = null;
        private GridView gridOfPictures = null;
        private AppCompatImageView uploadFromGallery = null;
        private AppCompatImageView takingNewPicture = null;
        public static readonly int PickImageId = 1000;
        public int chose = 0;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            this.gridOfPictures = view.FindViewById<GridView>(Resource.Id.pictures_gridview_all);
            this.pic = new Picture();
            this.theEvent = new Event(this.eventId);
            this.allPaths = this.pic.GetAllImagesStock().ToList<string>();
            gridOfPictures.Adapter = new PhotosAdapter(allPaths);

            gridOfPictures.ItemClick += GridOfPictures_ItemClick;
        }

        private void GridOfPictures_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            this.theEvent.AddPictureFromTheEventForClient(this.clientId, this.allPaths[e.Position]);
            Toast.MakeText(Activity, "Added successfully", ToastLength.Short).Show();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Bundle bundle = Arguments;
            this.clientId = bundle.GetInt("clientId", 0);
            this.eventId = bundle.GetInt("eventId", 0);

            View view = inflater.Inflate(Resource.Layout.big_gallery_frg, container, false);
            return view;
        }
    }
}