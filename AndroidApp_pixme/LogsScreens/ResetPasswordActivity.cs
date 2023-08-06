using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using BLFinalPro;

namespace PixmeApp
{
    [Activity(Label = "ResetPassword")]
    public class ResetPasswordFrg : Activity
    {
        private TextView remembered;
        private MyEditText username;
        private AppCompatImageView sendBtn;
        private Client client = null;
        private bool sent = false;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.reset_password);

            this.remembered = FindViewById<TextView>(Resource.Id.txt_remembered);
            this.username = FindViewById<MyEditText>(Resource.Id.username_for_reset);
            this.sendBtn = FindViewById<AppCompatImageView>(Resource.Id.reset_btn);

            remembered.Click += (sender, e) =>
            {
                Intent signInActivity = new Intent(this, typeof(SigninActivity));
                StartActivity(signInActivity);
            };

            sendBtn.Click += (sender, e) =>
            {
                client = new Client();
                sent = client.SendPasswordToEmailAddress(username.GetEditText().Text);
                if (sent)
                {
                    Toast.MakeText(this, "Please check your email.", ToastLength.Long).Show();
                }
                else
                {
                    Toast.MakeText(this, "The client does not exist in the system.", ToastLength.Long).Show();
                }
            };
        }
    }
}