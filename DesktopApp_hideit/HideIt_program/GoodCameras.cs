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
using HideItWF.ServiceReference1;
using HideItWF.ServiceReference2;

namespace HideItWF
{
    public partial class GoodCameras : Form
    {
        private Photographer thephotographer = null;

        public GoodCameras(Photographer photographer)
        {
            thephotographer = photographer;

            InitializeComponent();
        }

        private void GoodCameras_Load(object sender, EventArgs e)
        {
            ServiceReference2.IOhadWCFService client = new ServiceReference2.OhadWCFServiceClient();
            string[] emailAdressesArr = null;
            try
            {
                emailAdressesArr = client.GetMails();
            }
            catch
            {
                MessageBox.Show("ארעה שגיאה בחיבור השירותי רשת. אנא בדוק ששירות הרשת רץ");
            }

            camerasListBox.DataSource = emailAdressesArr;
        }

        private void gohomebtn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(this.thephotographer);
            homeForm.Show();
            this.Hide();
        }
    }
}
