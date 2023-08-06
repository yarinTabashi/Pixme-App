using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using BLFinalPro;

namespace PixmeApp
{
    public class EventRoomFrg : Fragment
    {
        private int clientId = 0;
        private int eventId = 0;
        private Event theEvent = null;
        private List<string> allPaths = null;
        private GridView gridOfPictures = null;
        private AppCompatImageView uploadFromGallery = null;
        private AppCompatImageView takingNewPicture = null;
        public static readonly int PickImageId = 1000;
        private Bundle bundle = null;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            this.gridOfPictures = view.FindViewById<GridView>(Resource.Id.pictures_gridview);
            this.uploadFromGallery = view.FindViewById<AppCompatImageView>(Resource.Id.upload_from_gallery_btn);
            this.takingNewPicture = view.FindViewById<AppCompatImageView>(Resource.Id.taking_new_pic_btn);

            this.theEvent = new Event(this.eventId);
            this.allPaths = this.theEvent.GetAllImagesPaths();

            gridOfPictures.Adapter = new PhotosAdapter(allPaths);

            uploadFromGallery.Click += (sender, e) =>
            {
                this.bundle = new Bundle();
                this.bundle.PutInt("clientId", this.clientId);
                this.bundle.PutInt("eventId", this.eventId);

                Fragment stockGalleryFrg = new GalleryStockFrg();
                stockGalleryFrg.Arguments = this.bundle;
                FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, stockGalleryFrg).Commit();
            };

            takingNewPicture.Click += (sender, e) =>
            {
                Intent intentB = new Intent(Android.Provider.MediaStore.ActionImageCapture);
                StartActivity(intentB);
            };

            gridOfPictures.ItemClick += GridOfPictures_ItemClick;
        }

        private void GridOfPictures_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Bundle bn = new Bundle();
            bn.PutString("imagePath", allPaths[e.Position]);
            Fragment imageDetailsFrg = new ImageDetailsFrg();
            imageDetailsFrg.Arguments = bundle;
            FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, imageDetailsFrg).Commit();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Bundle bundle = Arguments;
            this.clientId = bundle.GetInt("clientId", 0);
            this.eventId = bundle.GetInt("eventId", 0);

            View view = inflater.Inflate(Resource.Layout.fragment_grid_pictures, container, false);
            return view;
        }
    }
}