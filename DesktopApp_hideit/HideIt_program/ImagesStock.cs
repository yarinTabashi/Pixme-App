using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLFinalPro;

namespace HideItWF
{
    public partial class ImagesStock : Form
    {
        private Picture picture = null;
        private string name = "picture";
        private string tempName = "";
        private string[] imagesPaths = null;
        private string[] imagesNames = null;
        private Picture tempPic = null;
        private List<string> participantsInTheImage = null;

        public ImagesStock()
        {
            InitializeComponent();
        }

        private void ImagesStock_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Colmun 1", 200);

            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(200, 200);

            this.picture = new Picture();
            imagesPaths = this.picture.GetAllImagesStock();
            imagesNames = new string[imagesPaths.Length];

            MessageBox.Show("פעולה זו עשויה לקחת זמן רב", "המתן");
            
            try
            {
                for (int i = 0; i < imagesPaths.Length; i++)
                {
                    imgs.Images.Add("name", Converting.Convert(@imagesPaths[i]));
                }
                listView1.SmallImageList = imgs;

                for (int i = 0; i < imagesPaths.Length; i++)
                {
                    this.tempName = this.name + i.ToString();
                    imagesNames[i] = tempName;
                    listView1.Items.Add(imagesNames[i], i);
                    comboBox1.Items.Add(imagesNames[i]);
                }
            }
            catch
            {
                MessageBox.Show("ארעה שגיאה בטעינת התמונות");
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < imagesNames.Length; i++)
                {
                    if (comboBox1.SelectedItem.Equals(imagesNames[i]))
                    {
                        Program.imagePath = imagesPaths[i];
                        Program.flag = true;
                    }
                }

                tempPic = new Picture();
                this.participantsInTheImage = tempPic.GetParticipantsInImage(Program.imagePath);

                participantsListView.Columns.Add("Patricipants Names");
                participantsListView.View = View.Details;
                
                for (int i = 0; i < this.participantsInTheImage.Count; i++)
                {
                    participantsListView.Items.Add(this.participantsInTheImage[0]);
                }
                participantsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
                
                MessageBox.Show("נבחר בהצלחה", "אתה יכול לחזור למסך הקודם");
            }
            catch
            {
                MessageBox.Show("ארעה שגיאה", "אופס");
            }


        }
    }
}