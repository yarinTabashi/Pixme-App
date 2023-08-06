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
    public partial class AddImagesForEvent : Form
    {
        private int counter = 0;
        private Photographer thePhotographer = null;
        private List<int> lstId = new List<int>();
        List<string> lstNames = new List<string>();
        private Event anEvent = null;
        private int selectedIndex = 0;

        public AddImagesForEvent(Photographer thePhotographer)
        {
            this.thePhotographer = thePhotographer;
            InitializeComponent();
        }

        private void UploadImagesBtn_Click(object sender, EventArgs e)
        {
            ImagesStock imagesStock = new ImagesStock();
            imagesStock.ShowDialog();
            button1.Enabled = true;
        }

        private void AddImagesForEvent_Load(object sender, EventArgs e)
        {
            lstId = thePhotographer.GetEventIdYesUpcoming();
            lstNames = thePhotographer.GetEventNamesYesUpcoming();
            eventsNamesCbx.DataSource = lstNames;

            counterUploadsLbl.Text = counter.ToString() + "";

            button1.Enabled = false;
        }

        private void Gohomebtn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(this.thePhotographer);
            homeForm.Show();
            this.Hide();
        }

        private void EventsNamesCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = eventsNamesCbx.SelectedIndex;

            anEvent = new Event(lstId[selectedIndex]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.flag)
                {
                    anEvent.AddPictureFromTheEvent(this.thePhotographer.GetPhotographerId(), Program.imagePath);
                    Program.flag = false;

                    counter++;
                    counterUploadsLbl.Text = counter.ToString() + "";
                    MessageBox.Show("התמונות הועלו בהצלחה");
                }
                else
                {
                    MessageBox.Show("לא נבחרו תמונות");
                }
            }
            catch
            {
                MessageBox.Show("ארעה שגיאה בעת העלאת התמונות");
            }

            button1.Enabled = false;
        }
    }
}
