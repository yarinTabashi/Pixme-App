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
    public partial class WaitingForAcceptForm : Form
    {
        private List<int> lstId = new List<int>();
        List<string> lstNames = new List<string>();
        private Photographer thePhotographer = null;
        private int eventId;

        public WaitingForAcceptForm(Photographer photographer)
        {
            this.thePhotographer = photographer;
            InitializeComponent();
        }

        private void WaitingForAcceptForm_Load(object sender, EventArgs e)
        {
            lstNames = thePhotographer.GetNamesMaybeEvents();
            lstId = thePhotographer.GetIdMaybeEvents();
            eventsNamesCbx.DataSource = lstNames;
        }

        private void EventsNamesCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event anEvent;
            int selectedIndex = 0;
            selectedIndex = eventsNamesCbx.SelectedIndex;
            
            eventId = lstId[selectedIndex];
            anEvent = new Event(eventId);
            eventnamelabel.Text = anEvent.GetEventName().ToString() + "";
            eventdatelabel.Text = anEvent.GetEventDate().ToString() + "";
            eventdisclabel.Text = anEvent.GetEventDescription().ToString() + "";
        }

        private void Agreebtn_Click(object sender, EventArgs e)
        {
            bool succeed = false;

            try
            {
                succeed = thePhotographer.ConfirmEvent(this.eventId);
            }
            catch
            {
                MessageBox.Show("לא נבחר אירוע");
            }

            if (succeed)
            {
                agreebtn.Text = "אושר";
                agreebtn.BackColor = Color.Red;

                agreebtn.Enabled = false;
                noagreebtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("ארעה שגיאה, ייתכן שאתה כבר עובד ביום הזה");
            }
        }

        private void Noagreebtn_Click(object sender, EventArgs e)
        {
            bool succeed = false;

            try
            {
                succeed = thePhotographer.DontConfirmEvent(this.eventId);
            }
            catch
            {
                MessageBox.Show("לא נבחר אירוע");
            }

            if (succeed)
            {
                noagreebtn.Text = "לא מגיע";
                noagreebtn.BackColor = Color.Red;

                agreebtn.Enabled = false;
                noagreebtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("ארעה שגיאה");
            }
        }

        private void Gohomebtn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(this.thePhotographer);
            homeForm.Show();
            this.Hide();
        }
    }
}
