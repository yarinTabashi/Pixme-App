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
    public partial class MyPictures : Form
    {
        private Photographer thePhotographer;
        private List<int> picturesIdLst = new List<int>();
        private List<string> picturesPathLst = new List<string>();
        private int counter = 0;

        public MyPictures(Photographer thePhotographer)
        {
            this.thePhotographer = thePhotographer;
            InitializeComponent();
        }

        private void MyPictures_Load(object sender, EventArgs e)
        {
            DataSet ds = thePhotographer.GetMyAllImages(this.thePhotographer.GetPhotographerId());
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                picturesIdLst.Add(int.Parse(row["ImageID"].ToString()));
                picturesPathLst.Add(row["ImagePath"].ToString());
            }

            mainpbx.SizeMode = PictureBoxSizeMode.Zoom;
            lastimagebtn.Enabled = false;
            if (picturesIdLst.Count >= 2)
            {
                nextimagebtn.Enabled = true;
                mainpbx.Image = Converting.Convert(picturesPathLst[counter]);
                counter++;
            }
            else
            {
                nextimagebtn.Enabled = false;
            }
        }

        private void Nextimagebtn_Click(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                lastimagebtn.Enabled = true;
            }

            if (counter < picturesIdLst.Count - 1)
            {
                counter++;
                mainpbx.ImageLocation = picturesPathLst[counter].ToString();
            }
            else
            {
                nextimagebtn.Enabled = false;
            }
        }

        private void Lastimagebtn_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                mainpbx.ImageLocation = picturesPathLst[counter].ToString();
            }
            else
            {
                lastimagebtn.Enabled = false;
            }

            if (counter < picturesIdLst.Count - 1)
            {
                nextimagebtn.Enabled = true;
            }
        }

        private void Addtomyprofitolo_Click(object sender, EventArgs e)
        {
            this.thePhotographer.SetImageFromEventToProfitolo(int.Parse(picturesIdLst[this.counter - 1].ToString()));
        }

        private void GoToEditProfitoloForm_Click(object sender, EventArgs e)
        {
            EditProfitoloForm editProfitoloForm = new EditProfitoloForm(this.thePhotographer);
            editProfitoloForm.Show();
            this.Hide();
        }

        private void gohomebtn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(this.thePhotographer);
            homeForm.Show();
            this.Hide();
        }
    }
}
