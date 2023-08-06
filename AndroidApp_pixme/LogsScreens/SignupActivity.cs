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
using BLFinalPro;
using Android.Support.V7.Widget;
using Android.Text.Method;

namespace PixmeApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/StatusBarTransparentNoTitle", MainLauncher = true)]
    public class SignupActivity : Activity
    {
        public int clientId = 0;
        private MyEditText firstnamedt;
        private MyEditText lastnamedt;
        private MyEditText emailaddress;
        private MyEditText usernamedt;
        private MyEditText passworddt;
        private MyEditText repassworddt;
        private AppCompatImageView signupBtn;
        private Client theClient = new Client();
        private bool succeed = false;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.signup_activity);

            firstnamedt = FindViewById<MyEditText>(Resource.Id.first_name_dt_su);
            lastnamedt = FindViewById<MyEditText>(Resource.Id.last_name_dt_su);
            emailaddress = FindViewById<MyEditText>(Resource.Id.email_address_su);
            usernamedt = FindViewById<MyEditText>(Resource.Id.username_su);
            passworddt = FindViewById<MyEditText>(Resource.Id.password_su);
            repassworddt = FindViewById<MyEditText>(Resource.Id.re_password_su);

            signupBtn = FindViewById<AppCompatImageView>(Resource.Id.sign_up_btn_su);

            this.passworddt.GetEditText().TransformationMethod = new PasswordTransformationMethod();
            this.repassworddt.GetEditText().TransformationMethod = new PasswordTransformationMethod();

            signupBtn.Click += (sender, e) =>
            {
                if ((ValidaitionFirstName()) && (ValidaitionLastName() && ValidaitionEmailAddress() && ValidaitionUsername() && ValidaitionPassword() && ValidaitionRePassword()))
                {
                    try
                    {
                        succeed = theClient.SignUpForClient(firstnamedt.GetEditText().Text, lastnamedt.GetEditText().Text, "050", emailaddress.GetEditText().Text, usernamedt.GetEditText().Text, passworddt.GetEditText().Text);
                        if (succeed)
                        {
                            clientId = theClient.GetClientId();

                            Intent homeActivity = new Intent(this, typeof(HomeActivity));
                            homeActivity.PutExtra("clientId", theClient.GetClientId());
                            StartActivity(homeActivity);
                        }
                        else
                        {
                            Toast.MakeText(this, "One (or more) details are wrong.", ToastLength.Long).Show();
                        }

                    }
                    catch
                    {
                        Toast.MakeText(this, "One (or more) details are wrong.", ToastLength.Long).Show();
                    }
                }
            };
        }

        public bool ValidaitionFirstName()
        {
            if (firstnamedt.GetEditText().Text.Equals(""))
            {
                firstnamedt.GetEditText().Error = "Field can't be empty";
                return false;
            }

            firstnamedt.GetEditText().Error = null;
            return true;
        }


        public bool ValidaitionLastName()
        {
            if (lastnamedt.GetEditText().Text.Equals(""))
            {
                lastnamedt.GetEditText().Error = "Field can't be empty";
                return false;
            }

            lastnamedt.GetEditText().Error = null;
            return true;
        }


        public bool ValidaitionEmailAddress()
        {
            if (emailaddress.GetEditText().Text.Equals(""))
            {
                emailaddress.GetEditText().Error = "Field can't be empty";
                return false;
            }

            emailaddress.GetEditText().Error = null;
            return true;
        }


        public bool ValidaitionUsername()
        {
            if (usernamedt.GetEditText().Text.Equals(""))
            {
                usernamedt.GetEditText().Error = "Field can't be empty";
                return false;
            }

            usernamedt.GetEditText().Error = null;
            return true; ;
        }


        public bool ValidaitionPassword()
        {
            if (passworddt.GetEditText().Text.Equals(""))
            {
                passworddt.GetEditText().Error = "Field can't be empty";
                return false;
            }

            passworddt.GetEditText().Error = null;
            return true;
        }


        public bool ValidaitionRePassword()
        {
            if (repassworddt.GetEditText().Text.Equals("") || (!passworddt.GetEditText().Text.Equals(repassworddt.GetEditText().Text)))
            {
                repassworddt.GetEditText().Error = "The passwords don't match";
                return false;
            }

            repassworddt.GetEditText().Error = null;
            return true;
        }
    }
}
