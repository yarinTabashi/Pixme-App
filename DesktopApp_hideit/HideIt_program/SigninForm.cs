using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLFinalPro;

namespace HideItWF
{
    public partial class SigninForm : Form
    {
        public SigninForm()
        {
            InitializeComponent();
        }

        private void Gotosignuplabel_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }

        private void Signinbtn_Click(object sender, EventArgs e)
        {
            Photographer photographer = new Photographer();
            bool succeed = photographer.PhotographerSignIn(usernametbx.Text, passwordtbx.Text);

            if (succeed)
            {
                HomeForm homeForm = new HomeForm(photographer);
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("אראעה שגיאה");
            }
        }

        private void SigninForm_Load(object sender, EventArgs e)
        {

        }

        private void Usernametbx_Validaiting(object sender, CancelEventArgs e)
        {
            if ((usernametbx.Text.Length < 3) || (usernametbx.Text.Length > 20))
            {
                e.Cancel = true;
                errorProvider1.SetError(usernametbx, "ערך לא חוקי");
            }
        }

        private void Passwordtbx_Validaiting(object sender, CancelEventArgs e)
        {
            if ((passwordtbx.Text.Length < 3) || ((passwordtbx.Text.Length > 20)))
            {
                e.Cancel = true;
                errorProvider1.SetError(passwordtbx, "ערך לא חוקי");
            }
        }
    }
}
