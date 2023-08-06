using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Text;
using Android.Text.Method;
using Android.Views;
using Android.Widget;
using BLFinalPro;

namespace PixmeApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/StatusBarTransparentNoTitle", MainLauncher = true)]
    public class SigninActivity : Activity
    {
        private int clientId = 0;
        private MyEditText usernamedt;
        private MyEditText passworddt;
        private AppCompatImageView signiBtn;
        private Client theClient = new Client();
        private bool succeed = false;
        private TextView forgotPassword;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.signin_activity);

            usernamedt = FindViewById<MyEditText>(Resource.Id.usernametxt);
            passworddt = FindViewById<MyEditText>(Resource.Id.passwordtxt);
            signiBtn = FindViewById<AppCompatImageView>(Resource.Id.signing_in_btn);
            forgotPassword = FindViewById<TextView>(Resource.Id.forgot_the_pas_btn);

            this.passworddt.GetEditText().InputType = InputTypes.TextVariationPassword;
            this.passworddt.GetEditText().TransformationMethod = new PasswordTransformationMethod();


            signiBtn.Click += (sender, e) =>
            {
                if ((ValidaitionPassword()) && (ValidaitionUsername()))
                {
                    try
                    {
                        succeed = theClient.SignIn(usernamedt.GetEditText().Text, passworddt.GetEditText().Text);
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

            forgotPassword.Click += (sender, e) =>
            {
                Intent resetPassword = new Intent(this, typeof(ResetPasswordFrg));
                StartActivity(resetPassword);
            };

        }


        private bool ValidaitionUsername()
        {
            string usernameInput = usernamedt.GetEditText().Text;

            if (usernameInput.Equals(""))
            {
                usernamedt.GetEditText().Error = "Field can't be empty";
                return false;
            }

            usernamedt.GetEditText().Error = null;
            return true;
        }

        private bool ValidaitionPassword()
        {
            string passwordInput = passworddt.GetEditText().Text;

            if (passwordInput.Equals(""))
            {
                passworddt.GetEditText().Error = "Field can't be empty";
                return false;
            }

            passworddt.GetEditText().Error = null;
            return true;
        }
    }
}