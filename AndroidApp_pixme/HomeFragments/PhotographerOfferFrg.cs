using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using BLFinalPro;

namespace PixmeApp
{
    [Activity(Label = "PhotographerActivity")]
    public class PhotographerActivity : Fragment
    {
        private int eventId = 0;
        private int photographerId = 0;
        private TextView photographerName = null;
        private AppCompatImageView bookPhotographerBtn = null;
        private Event theEvent = null;
        private Photographer thePhotographer = null;
        private int clientId = 0;

        List<string> picturesPathLst = null;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            this.photographerName = view.FindViewById<TextView>(Resource.Id.photographer_name_txtv);
            this.bookPhotographerBtn = view.FindViewById<AppCompatImageView>(Resource.Id.book_photographer_btn);

            this.thePhotographer = new Photographer();
            this.thePhotographer.SignInById(this.photographerId);
            this.photographerName.Text = this.thePhotographer.GetNameById();

            this.picturesPathLst = thePhotographer.GetProfitoloPath();
            GalleryAdapter adapter = new GalleryAdapter(Activity, picturesPathLst);

            // Find the ViewPager and plug in the adapter:
            ViewPager pager = (ViewPager)view.FindViewById(Resource.Id.my_pager);
            pager.Adapter = adapter;


            this.bookPhotographerBtn.Click += (sender, e) =>
            {
                this.theEvent = new Event(this.eventId);
                this.theEvent.InvitePhotographer(this.photographerId);

                Bundle bn = new Bundle();
                bn.PutInt("clientId", this.clientId);
                bn.PutInt("eventId", this.eventId);
                Fragment searchFriendsFrg = new SelectInvitesFrg();
                searchFriendsFrg.Arguments = bn;
                FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, searchFriendsFrg).Commit();
            };
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Bundle bundle = Arguments;
            this.eventId = bundle.GetInt("eventId", 0);
            this.clientId = bundle.GetInt("clientId", 0);
            this.photographerId = bundle.GetInt("photographerId", 0);

            View view = inflater.Inflate(Resource.Layout.fragment_photography, container, false);
            return view;
        }
    }
}