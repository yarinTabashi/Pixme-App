using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BLFinalPro;

namespace HideItWF
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void Gotosigninlabel_Click(object sender, EventArgs e)
        {
            SigninForm signinForm = new SigninForm();
            signinForm.Show();
            this.Hide();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
        }


        private void Chooseimagesbtn_Click(object sender, EventArgs e)
        {
            string imageLocaition = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "*jpg files(*jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocaition = dialog.FileName;
                    profilepbx.ImageLocation = imageLocaition;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("התרחשה שגיאה בעת העלאת התמונה");
            }
        }

        private bool EverythingIsOKFirst()
        {
            if ((firstnametbx.Text.Length > 2) && (lastnametbx.Text.Length > 2) && (emailtbx.Text.Length > 0))
            {
                return true;
            }
            return false;
        }

        private void Signupbtn_Click(object sender, EventArgs e)
        {
            if (EveryThingIsOKTwo())
            {
                {
                    try
                    {
                        Photographer photographer = new Photographer();
                        photographer.PhotographerSignUp(firstnametbx.Text, lastnametbx.Text, phonetbx.Text, emailtbx.Text, 5, usernametbx.Text, passwordtbx.Text);

                        SendingNotifications sendingNotifications = new SendingNotifications();
                        sendingNotifications.SendingMail("שלום רב, הרשמתך נקלטה במערכת. המשך גלישה נעימה", emailtbx.Text.ToString(), "הרשמתך נקלטה במערכת");

                        SigninForm signInForm = new SigninForm();
                        signInForm.Show();
                        this.Hide();
                    }
                    catch
                    {
                        MessageBox.Show("ארעה שגיאה");
                    }
                }
            }
            else 
            {
                MessageBox.Show("יש להשלים את כל הפרטים");
            }
        }

        private bool EveryThingIsOKTwo()
        {
            if ((usernametbx.Text.Length > 3) && (passwordtbx.Text.Length > 4) && (passwordtbx.Text.Equals(repasswordtbx.Text) && (phonetbx.MaskFull)))
            {
                return true;
            }
            return false;
        }

        private void Firstnametbx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(firstnametbx.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(firstnametbx, "ערך לא חוקי");
            }
        }

        private void Lastnametbx_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(lastnametbx.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(lastnametbx, "ערך לא חוקי");
            }
        }

        private void Emailtbx_Validating(object sender, CancelEventArgs e)
        {
            if ((string.IsNullOrEmpty(emailtbx.Text) || (!Regex.IsMatch(emailtbx.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))))
            {
                e.Cancel = true;
                errorProvider1.SetError(emailtbx, "ערך לא חוקי");
            }
        }

        private void Usernametbx_Validaiting(object sender, CancelEventArgs e)
        {
            if ((string.IsNullOrEmpty(usernametbx.Text)) || (usernametbx.Text.Length > 20))
            {
                e.Cancel = true;
                errorProvider1.SetError(usernametbx, "ערך לא חוקי");
            }
        }

        private void Passwordtbx_Validaiting(object sender, CancelEventArgs e)
        {
            if ((string.IsNullOrEmpty(passwordtbx.Text)) || (passwordtbx.Text.Length > 20))
            {
                e.Cancel = true;
                errorProvider1.SetError(passwordtbx, "ערך לא חוקי");
            }
        }

        private void Repasswordtbx_Validaiting(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(passwordtbx.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(repasswordtbx, "ערך לא חוקי");
            }
            else
            {
                if (!repasswordtbx.Text.Equals(passwordtbx.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(passwordtbx, "אין התאמה");
                }
            }
        }

        private void Phonetbx_Validating(object sender, CancelEventArgs e)
        {
            if (!phonetbx.MaskFull)
            {
                e.Cancel = true;
                errorProvider1.SetError(phonetbx, "ערך לא חוקי");
            }
        }
    }
}
