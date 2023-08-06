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
    public partial class GetDetailsForm : Form
    {
        private int eventid = 0;
        private int photographerId = 0;

        public GetDetailsForm(int id, int photographerId)
        {
            this.eventid = id;
            this.photographerId = photographerId;

            InitializeComponent();
        }

        private void GetDetailsForm_Load(object sender, EventArgs e)
        {
            Event theEvent = new Event(this.eventid);
            eventnamelabel.Text = theEvent.GetEventName().ToString() + "";
            eventdatelabel.Text = theEvent.GetEventDate().ToString() + "";
            eventdisclabel.Text = theEvent.GetEventDescription().ToString() + "";

            if (theEvent.GetStatusOfPhotographerAboutEvent(photographerId).Equals("Yes"))
            {
                needToacceptPanel.Visible = false;
                alreadyacceptedPanel.Visible = true;
            }
            else
            {
                needToacceptPanel.Visible = true;
                alreadyacceptedPanel.Visible = false;
            }
        }
    }
}
