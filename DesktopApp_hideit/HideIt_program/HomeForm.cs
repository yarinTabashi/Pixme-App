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
    public partial class HomeForm : Form
    {
        private Photographer thephotographer = null;
        private int closeEventId = 0;
        private string photographerUsername = "";
        private string photographerPassword = "";

        public HomeForm(Photographer photographer)
        {
            thephotographer = photographer;

            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            photographerUsername = thephotographer.GetUsername();
            photographerPassword = thephotographer.GetPassword();
            firstnamelabel.Text = thephotographer.GetFullName() + "";

            upcomingeventslabel.Text = thephotographer.GetCounterYesEvnets() + "";
            dontwanteventslabel.Text = thephotographer.GetCounterNoEvnets() + "";
            c.Text = thephotographer.GetCounterMaybeEvnets() + "";

            //profilepbx.ImageLocation = thephotographer.GetProfilePath();

            // מציאת האירוע הקרוב
            this.closeEventId = thephotographer.GetCloseEventId();
            if (closeEventId == 0)
            {
                noeventsPanel.Visible = true;
            }
            else
            {
                noeventsPanel.Visible = false;
                Event closeEvent = new Event(closeEventId);                
                daysLeftCloselabel.Text = closeEvent.GetDaysLeft().ToString() + "";
                datelabel.Text = closeEvent.GetEventDate().ToString() + "";
            }

            
        }

        private void Getdetbtn_Click(object sender, EventArgs e)
        {
            GetDetailsForm detailsForm = new GetDetailsForm(this.closeEventId, thephotographer.GetPhotographerId());
            detailsForm.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Gotoeditprofitolobtn_Click(object sender, EventArgs e)
        {
            EditProfitoloForm editProfitoloForm = new EditProfitoloForm(this.thephotographer);
            editProfitoloForm.Show();
            this.Hide();
        }

        private void GoToWaiting_Click(object sender, EventArgs e)
        {
            WaitingForAcceptForm waitingForAcceptForm = new WaitingForAcceptForm(this.thephotographer);
            waitingForAcceptForm.Show();
            this.Hide();
        }

        private void GoToUpComing_Click(object sender, EventArgs e)
        {
            UpcomingEventsForm upcomingEventsForm = new UpcomingEventsForm(this.thephotographer);
            upcomingEventsForm.Show();
            this.Hide();
        }

        private void GoToUploadFormBtn_Click(object sender, EventArgs e)
        {
            AddImagesForEvent addImagesForEvent = new AddImagesForEvent(this.thephotographer);
            addImagesForEvent.Show();
            this.Hide();
        }

        private void offerMeBtn_Click(object sender, EventArgs e)
        {
            GoodCameras goodCamerasForm = new GoodCameras(this.thephotographer);
            goodCamerasForm.Show();
            this.Hide();
        }
    }
}
