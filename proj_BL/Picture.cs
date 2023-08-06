using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalDBPro;
using System.Data;
using System.Net;

namespace BLFinalPro
{
    public class Picture
    {
        private string picturePath; 
        private List<int> pictureParticipants; 
        private List<string> participantsPhotoPermission; 

        public Picture()
        {
            this.picturePath = "";
            this.pictureParticipants = null;
            this.participantsPhotoPermission = null;
        }

        public bool SetPictureByPicId(int pictureId)
        {
            try
            {
                DataRow dr = PictureDal.GetImageByID(pictureId);
                this.picturePath = dr["ImagePath"].ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GetPicturePath()
        {
            return this.picturePath;
        }

        public List<int> FindSimilarPictures()
        {
            return new List<int>();
        }

        public List<int> WhoNeedToBlur()
        {
            return new List<int>();
        }

        public string[] GetAllImagesStock()
        {
            string[] imagesPaths;
            DataColumn dc = PictureDal.GetAllImagesStock();
            List<string> lst = new List<string>();

            imagesPaths = new string[dc.Table.Rows.Count];

            foreach (DataRow row in dc.Table.Rows)
            {
                lst.Add(row[0].ToString());
            }

            imagesPaths = lst.ToArray();

            return imagesPaths;
        }

        public List<string> GetParticipantsInImage(string imageUrl)
        {
            List<int> participantsId = new List<int>();
            List<string> participantsNames = new List<string>();
            int tempBlur;
            Client client = new Client();
            List<string> blurLst = new List<string>();
            int imageId = 0;
            imageId = PictureDal.GetImageIdFromStockTblByURL(imageUrl);

            DataColumn dcIds = PictureDal.GetImageParticipantsIds(imageId);
            DataColumn dcBlur = PictureDal.GetImageParticipantsBlurs(imageId);

            for (int i = 0; i < dcIds.Table.Rows.Count; i++)
            {
                participantsId.Add(int.Parse((dcIds.Table.Rows[i][0].ToString())));
                tempBlur = int.Parse((dcBlur.Table.Rows[i][0].ToString()));
                
                if (tempBlur == 0)
                {
                    blurLst.Add("isn't blur!");
                }
                else
                {
                    if (tempBlur == 1)
                    {
                        blurLst.Add("is blur!");
                    }
                }
            }

            for (int i = 0; i < participantsId.Count; i++)
            {
                client.SignInById(participantsId[i]);
                participantsNames.Add(client.GetFullName() + " " + blurLst[i]);
            }

            return participantsNames;
        }
    }
}
