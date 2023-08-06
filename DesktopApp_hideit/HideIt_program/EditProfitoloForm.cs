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
    public partial class EditProfitoloForm : Form
    {
        private Photographer thePhotographer = null;
        private List<int> picturesIdLst = new List<int>();
        private List<string> picturesPathLst = new List<string>();
        private int counter = 0;

        public EditProfitoloForm(Photographer thePhotographer)
        {
            InitializeComponent();

            this.thePhotographer = thePhotographer;
        }

        private void Gohomebtn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(this.thePhotographer);
            homeForm.Show();
            this.Hide();
        }

        private void EditProfitoloForm_Load(object sender, EventArgs e)
        {
            DataSet ds = thePhotographer.GetProfitolo(this.thePhotographer.GetPhotographerId());
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
                mainpbx.Image = Converting.Convert(picturesPathLst[counter]);
                nextimagebtn.Enabled = false;
            }
        }

        private void Addnewimagebtn_Click(object sender, EventArgs e)
        {
            string imageLocaition = "";

            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "*jpg files(*jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*"
            };

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imageLocaition = dialog.FileName;
                thePhotographer.AddPictureForProfitolo(imageLocaition);
            }
        }

        private void GotoallmypicturesBtn_Click(object sender, EventArgs e)
        {
            MyPictures myPicturesForm = new MyPictures(this.thePhotographer);
            myPicturesForm.Show();
            this.Hide();
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
    }
}
