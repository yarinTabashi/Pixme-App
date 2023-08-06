using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FinalDBPro
{
    public class PictureDal
    {

        public static void AddImageFromEvent(string imagePath, int photographerId, int eventId)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand(String.Format(("INSERT INTO TblImages (ImagePath, PhotographerId, IsForProfitolo, EventId, ClientId) VALUES ('{0}', {1}, 0, {2}, 0)"), imagePath, photographerId, eventId));
            helper.Disconnect();
        }

        public static void AddImageFromEventClient(string imagePath, int clientId, int eventId)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand(String.Format(("INSERT INTO TblImages (ImagePath, ClientId, IsForProfitolo, EventId, PhotographerId) VALUES ('{0}', {1}, 0, {2}, 0)"), imagePath, clientId, eventId));
            helper.Disconnect();
        }

        public static void AddImageForProfitolo(string imagePath, int photographerId)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand(String.Format(("INSERT INTO TblImages (ImagePath, PhotographerId, IsForProfitolo) VALUES ('{0}', {1}, 1)"), imagePath, photographerId));
            helper.Disconnect();
        }

        public static void SetImageFromEventToProfitolo(int imageID)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand(String.Format("UPDATE TblImages SET IsForProfitolo=1 WHERE ImageID={0}", imageID));
            helper.Disconnect();
        }


        public static void RemoveImage(int idImage)
        {
            Helper helper = new Helper();
            helper.ExecuteSqlCommand(String.Format("DELETE From TblImages WHERE ImageID={0}", idImage));
            helper.Disconnect();
        }

        public static DataSet GetAllImagesTable()
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery("SELECT * FROM TblImages");
            helper.Disconnect();
            return ds;
        }

        public static DataSet GetAllImagesOfPhotographer(int photographerId)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format("Select * From TblImages WHERE PhotographerId={0}", photographerId));
            helper.Disconnect();
            return ds;
        }

        public static DataSet GetPhotographerProfitolo(int photographerId)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format("Select * From TblImages WHERE PhotographerId={0} AND IsForProfitolo=1", photographerId));
            helper.Disconnect();
            return ds;
        }

        public static DataRow GetImageByID(int imageID)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("Select * From TblImages WHERE ImageID={0}", imageID));
            helper.Disconnect();
            return ds.Tables[0].Rows[0];
        }

        public static string GetImagePathByID(int imageID)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("SELECT ImagePath From TblImages WHERE ImageID={0}", imageID));
            helper.Disconnect();
            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static void SetImagePath(string imagePath, int imageID)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand(String.Format("UPDATE TblImages SET ImagePath='{0}' WHERE ImageID={1}", imagePath, imageID));
            helper.Disconnect();
        }

        public static void AddParticipantToImage(int imageID, int clientID)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand(String.Format("INSERT INTO Tbl_Image_Clients Values ({0}, {1})", imageID, clientID));
            helper.Disconnect();
        }

        public static DataColumn GetAllParticipantsOfImage(int imageID)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("Select Client_ID From Tbl_Image_Clients WHERE image_id={0}", imageID));
            helper.Disconnect();
            return ds.Tables[0].Columns[0];
        }

        public static DataSet GetAllImagesOfClient(int clientID)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("Select Image_ID From Tbl_Image_Clients WHERE Client_ID={0}", clientID));
            helper.Disconnect();
            return ds;
        }

        public static DataSet GetAllImagesBetweenClients()
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery("SELECT * FROM Tbl_Image_Clients");
            helper.Disconnect();
            return ds;
        }

        public static int GetLastPictureId()
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery("SELECT * FROM TblImages ORDER BY ClientID ASC");
            helper.Disconnect();
            return int.Parse(ds.Tables[0].Rows[0][0].ToString());
        }

        public static DataColumn GetAllImagesStock()
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery("Select ImageURL FROM TblStockImages");
            helper.Disconnect();

            return ds.Tables[0].Columns[0];
        }

        public static int GetImageIdFromStockTblByURL(string imageUrl)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("Select ImageIDFromStock From TblStockImages WHERE ImageURL LIKE '{0}'"), imageUrl));
            helper.Disconnect();
            return int.Parse(ds.Tables[0].Rows[0][0].ToString());
        }

        public static DataColumn GetImageParticipantsIds(int imageId)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("Select ClientID From TblImagesParticiapnts WHERE ImageID={0}"), imageId));
            helper.Disconnect();
            return ds.Tables[0].Columns[0];
        }

        public static DataColumn GetImageParticipantsBlurs(int imageId)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("Select Blur From TblImagesParticiapnts WHERE ImageID={0}"), imageId));
            helper.Disconnect();
            return ds.Tables[0].Columns[0];
        }
    }
}