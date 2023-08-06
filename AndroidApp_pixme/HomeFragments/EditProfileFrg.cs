using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Text.Method;
using Android.Util;
using Android.Views;
using Android.Widget;
using BLFinalPro;

namespace PixmeApp
{
    public class EditProfileFrg : Fragment
    {
        private int clientId = 0;
        private Client client = null;
        private MyEditText firstNameEdtx;
        private MyEditText lastNameEdtx;
        private MyEditText usernameEdtx;
        private MyEditText emailAddressEdtx;
        private MyEditText phoneNumberEdtx;
        private MyEditText currentPasswordEdtx;
        private MyEditText newPasswordEdtx;
        private MyEditText rePasswordEdtx;
        private AppCompatImageView saveChangesBtn;
        
        private string firstName = "";
        private string lastName = "";
        private string username = "";
        private string emailAddress = "";
        private string phoneNum = "";

        private Bundle bundle;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            //base.OnViewCreated(view, savedInstanceState);

            this.client = new Client();
            this.client.SignInById(this.clientId);
            
            this.firstNameEdtx = view.FindViewById<MyEditText>(Resource.Id.edit_first_name);
            this.lastNameEdtx = view.FindViewById<MyEditText>(Resource.Id.edit_last_name);
            this.usernameEdtx = view.FindViewById<MyEditText>(Resource.Id.edit_username);
            this.phoneNumberEdtx = view.FindViewById<MyEditText>(Resource.Id.edit_phone_num);
            this.emailAddressEdtx = view.FindViewById<MyEditText>(Resource.Id.edit_email_address);
            this.currentPasswordEdtx = view.FindViewById<MyEditText>(Resource.Id.edit_current_password);
            this.newPasswordEdtx = view.FindViewById<MyEditText>(Resource.Id.edit_new_password);
            this.rePasswordEdtx = view.FindViewById<MyEditText>(Resource.Id.edit_re_password);
            this.saveChangesBtn = view.FindViewById<AppCompatImageView>(Resource.Id.save_changes_edit);

            // הסתרת הסיסמאות
            this.currentPasswordEdtx.GetEditText().TransformationMethod = new PasswordTransformationMethod();
            this.newPasswordEdtx.GetEditText().TransformationMethod = new PasswordTransformationMethod();
            this.rePasswordEdtx.GetEditText().TransformationMethod = new PasswordTransformationMethod();

            // שדות שלא ניתנים לשינוי
            this.firstNameEdtx.GetEditText().Enabled = false;
            this.lastNameEdtx.GetEditText().Enabled = false;
            this.usernameEdtx.GetEditText().Enabled = false;

            this.firstName = this.client.GetFirstName();
            this.lastName = this.client.GetLastName();
            this.username = this.client.GetUsername();
            this.emailAddress = this.client.GetEmailAddress();
            this.phoneNum = this.client.GetPhoneNumber();

            this.firstNameEdtx.GetEditText().Text = this.firstName;
            this.lastNameEdtx.GetEditText().Text = this.lastName;
            this.usernameEdtx.GetEditText().Text = this.username;
            this.emailAddressEdtx.GetEditText().Text = this.emailAddress;
            this.phoneNumberEdtx.GetEditText().Text = this.phoneNum;

            
            saveChangesBtn.Click += (sender, e) => // כפתור שמירת שינויים
            {
                try
                {
                    // טיפול בשינוי סיסמה
                    if (!this.currentPasswordEdtx.GetEditText().Text.Equals("")) // בדיקה אם משתמש כתב סיסמה חדשה 
                    {
                        if (this.currentPasswordEdtx.GetEditText().Text.Equals(this.client.GetPassword())) // בדיקה אם הסיסמה הנוכחית נכונה
                        {
                            if (this.newPasswordEdtx.GetEditText().Text.Equals(this.rePasswordEdtx.GetEditText().Text)) // בדיקת התאמת הסיסמאות
                            {
                                this.client.SetPassword(newPasswordEdtx.GetEditText().Text);
                            }
                            else
                            {
                                Toast.MakeText(Activity, "Passwords do not match", ToastLength.Long).Show();
                                return;
                            }
                        }
                        else
                        {
                            Toast.MakeText(Activity, "The current password you entered is incorrect", ToastLength.Long).Show();
                            return;
                        }
                    }
                    
                    if (!this.emailAddressEdtx.GetEditText().Text.Equals(this.emailAddress))
                    {
                        this.client.SetEmailAddress(this.emailAddressEdtx.GetEditText().Text);
                    }

                    if (!this.phoneNumberEdtx.GetEditText().Text.Equals(this.phoneNum))
                    {
                        this.client.SetPhoneNum(this.phoneNumberEdtx.GetEditText().Text);
                    }

                    Toast.MakeText(Activity, "Changes saved successfully", ToastLength.Long).Show();

                    this.bundle.PutInt("clientId", this.clientId);
                    Fragment homeFrg = new HomeFrg();
                    homeFrg.Arguments = bundle;
                    FragmentManager.BeginTransaction().Replace(Resource.Id.fragment_container_home, homeFrg).Commit();
                }
                catch
                {
                    Toast.MakeText(Activity, "An error occurred!", ToastLength.Long).Show();
                }
            };
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Bundle bundle = Arguments;
            this.clientId = bundle.GetInt("clientId", 0);

            View view = inflater.Inflate(Resource.Layout.edit_profile, container, false);
            return view;
        }
    }
}