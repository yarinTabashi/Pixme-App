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
using Android.Support.Compat;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;
using Android.Support.V7.Widget;
using ActionBar = Android.Support.V7.App.ActionBar;
using Android.Support.V7.App;

namespace PixmeApp
{
    [Activity(Label = "HomeActivity", Theme = "@style/StatusBarTransparentNoTitle")]
    public class HomeActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        private int clientId = 0;
        private NavigationView navigationView;
        private DrawerLayout drawerLayout;
        private Bundle bundle = null;

        public bool OnNavigationItemSelected(IMenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.home_activity);

            this.clientId = Intent.GetIntExtra("clientId", 0);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar1);
            SetSupportActionBar(toolbar);

            //Enable support action bar to display hamburger
            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_menu_drawer);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.NavigationItemSelected += NavigationView_NavigationItemSelected;


            this.bundle = new Bundle();
            this.bundle.PutInt("clientId", this.clientId);

            Fragment homeFrg = new HomeFrg();
            homeFrg.Arguments = bundle;
            FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, homeFrg).Commit();

            navigationView.NavigationItemSelected += (sender, e) =>
            {
                e.MenuItem.SetChecked(true);
                //react to click here and swap fragments or navigate
                drawerLayout.CloseDrawers();

                // Create your application here

            };
        }

        private void NavigationView_NavigationItemSelected(object sender, NavigationView.NavigationItemSelectedEventArgs e)
        {
            switch (e.MenuItem.ItemId)
            {
                case Resource.Id.navigation_home:
                    {
                        this.bundle = new Bundle();
                        this.bundle.PutInt("clientId", this.clientId);

                        Fragment homeFrg = new HomeFrg();
                        homeFrg.Arguments = this.bundle;
                        FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, homeFrg).Commit();
                        break;
                    };

                case Resource.Id.navigation_upcoming_events:
                    {
                        //if (bundle == null)
                        {
                            this.bundle = new Bundle();
                            this.bundle.PutInt("clientId", this.clientId);

                            Fragment upcomingFrg = new UpcomingEventsFragment();
                            upcomingFrg.Arguments = this.bundle;
                            FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, upcomingFrg).Commit();
                            break;
                        }
                        //else
                        //{
                        //    Fragment upcomingFrg = new UpcomingEventsFragment();
                        //    FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, upcomingFrg).Commit();                       
                        //    break;
                        //}
                    };

                case Resource.Id.navigation_edit_profile:
                    {
                        //if (bundle == null)
                        {
                            this.bundle = new Bundle();
                            this.bundle.PutInt("clientId", this.clientId);

                            Fragment editProfileFrg = new EditProfileFrg();
                            editProfileFrg.Arguments = this.bundle;
                            FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, editProfileFrg).Commit();
                            break;
                        }
                    };

                case Resource.Id.navigation_calendar_manager:
                    {
                        //if (bundle == null)
                        {
                            this.bundle = new Bundle();
                            this.bundle.PutInt("clientId", this.clientId);

                            Fragment calendarManagerFrg = new CalendarManagerFrg();
                            calendarManagerFrg.Arguments = this.bundle;
                            FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, calendarManagerFrg).Commit();
                            break;
                        }
                    };

                case Resource.Id.navigation_create_new_event:
                    {
                        //if (bundle == null)
                        {
                            this.bundle = new Bundle();
                            this.bundle.PutInt("clientId", this.clientId);

                            Fragment dateFrg = new ChooseDateFrg();
                            dateFrg.Arguments = this.bundle;
                            FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, dateFrg).Commit();
                            break;
                        }
                    };

                case Resource.Id.navigation_my_friends:
                    {
                        //if (bundle == null)
                        {
                            this.bundle = new Bundle();
                            this.bundle.PutInt("clientId", this.clientId);

                            Fragment myFriendsFrg = new MyFriendsFrg();
                            myFriendsFrg.Arguments = this.bundle;
                            FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, myFriendsFrg).Commit();
                            break;
                        }
                    };
            }
            //drawerLayout.CloseDrawers();
        }

        // טיפול בלחיצה על מקש חזרה לאחור
        public override void OnBackPressed()
        {
            Fragment homeFrg = new HomeFrg();
            homeFrg.Arguments = bundle;
            FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, homeFrg).Commit();

            Toast.MakeText(this, "If you want exit, press on Home-Button", ToastLength.Long).Show();
        }
    }
}