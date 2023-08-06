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
using System.Net.NetworkInformation;

namespace PixmeApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/StatusBarTransparentNoTitle", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            ImageView signupBtn = FindViewById<ImageView>(Resource.Id.signupimv);
            TextView loginbnt = FindViewById<TextView>(Resource.Id.txt_aleready_log_in);

            signupBtn.Click += (sender, e) =>
            {
                Intent signupIntent = new Intent(this, typeof(SignupActivity));
                StartActivity(signupIntent);
            };

            loginbnt.Click += (sender, e) =>
            {
                Intent signInIntent = new Intent(this, typeof(SigninActivity));
                StartActivity(signInIntent);
            };
        }

        // בדיקת חיבור לאינטרנט
        private bool IsInternetAviable()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}