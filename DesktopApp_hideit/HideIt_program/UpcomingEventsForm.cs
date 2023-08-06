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
    public partial class UpcomingEventsForm : Form
    {
        private int firstEventId = 0;
        private int secondEventId = 0;
        private int thirdEventId = 0;
        private Photographer thePhotographer = null;
        private int upcomingEventsCounter = 0;

        public UpcomingEventsForm(Photographer photographer)
        {
            this.thePhotographer = photographer;
            InitializeComponent();
        }

        private void Detailsevent1btn_Click(object sender, EventArgs e)
        {
            GetDetailsForm detailsForm = new GetDetailsForm(firstEventId, thePhotographer.GetPhotographerId());
            detailsForm.Show();
        }

        private void Detailsevent2btn_Click(object sender, EventArgs e)
        {
            GetDetailsForm detailsForm = new GetDetailsForm(secondEventId, thePhotographer.GetPhotographerId());
            detailsForm.Show();
        }

        private void Detailsevent3btn_Click(object sender, EventArgs e)
        {
            GetDetailsForm detailsForm = new GetDetailsForm(thirdEventId, thePhotographer.GetPhotographerId());
            detailsForm.Show();
        }

        private void UpcomingEventsForm_Load(object sender, EventArgs e)
        {
            upcomingEventsCounter = thePhotographer.GetCounterYesUpcoming();
            upcomingcounterlabel.Text = upcomingEventsCounter.ToString() + "";
            dontwanteventslabel.Text = thePhotographer.GetCounterNoEvnets().ToString() + "";
            maybecounterlabel.Text = thePhotographer.GetCounterMaybeEvnets().ToString() + "";

            DataSet ds = thePhotographer.GetDataSetOfUpcomingEvents();

            DataTable dtAll = ds.Tables[0].Copy();
            for (var i = 1; i < ds.Tables.Count; i++)
            {
                dtAll.Merge(ds.Tables[i]);
            }

            dtAll.Columns.Remove("EventID");
            dtAll.Columns.Remove("EventMannagerID");
            dtAll.Columns.Remove("EventNeedPhotographer");
            dtAll.Columns.Remove("EventType");

            upcomingDvg.AutoGenerateColumns = true;
            upcomingDvg.DataSource = dtAll;
        }

        private void gohomebtn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(this.thePhotographer);
            homeForm.Show();
            this.Hide();
        }
    }
}
