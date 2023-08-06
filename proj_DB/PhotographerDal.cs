using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FinalDBPro
{
    public class PhotographerDal
    {
        public static DataSet GetAllPhotographers()
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery("SELECT PhotographerID FROM TblPhotographers");
            helper.Disconnect();
            return ds;
        }

        public static int GetPhotographerRaiting(int photographerId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("SELECT PhotographerRating From TblPhotographers WHERE PhotographerID={0}", photographerId));
            helper.Disconnect();

            return int.Parse(ds.Tables[0].Rows[0][0].ToString());
        }

        public static void RemovePhotographer(int photographerId)
        {
            Helper helper = new Helper();
            helper.ExecuteSqlCommand(String.Format("Delete From TblPhotographers WHERE PhotographerID={0}", photographerId));
            helper.Disconnect();
        }

        public static void SignUpForPhotographer(string photographerFirstName, string photographerLastName, string photographerPhoneNumber, string photographerEmailAddress, int photographerRating, string photographerUsername, string photographerPassword)
        {
            Helper helper = new Helper();
            helper.ExecuteSqlCommand(String.Format("INSERT INTO TblPhotographers (photographerFirstName, photographerLastName, photographerPhoneNumber, photographerEmailAddress, photographerRating, photographerUsername, photographerPassword) VALUES('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}')", photographerFirstName, photographerLastName, photographerPhoneNumber, photographerEmailAddress, photographerRating, photographerUsername, photographerPassword));
            helper.Disconnect();
        }

        public static DataRow LoginForPhotographer(string userName, string password)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("SELECT * From TblPhotographers WHERE PhotographerUsername LIKE '{0}' AND PhotographerPassword LIKE \'{1}\'"), userName, password));
            helper.Disconnect();
            return ds.Tables[0].Rows[0];
        }

        public static DataRow LoginForPhotographer(int photographerId)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("SELECT * From TblPhotographers WHERE PhotographerId={0}"), photographerId));
            helper.Disconnect();
            return ds.Tables[0].Rows[0];
        }

        public static string GetFirstNameById(int photographerId)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("SELECT PhotographerFirstName From TblPhotographers WHERE PhotographerID={0}"), photographerId));
            helper.Disconnect();
            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static void AddBusyDate(int photographerID, DateTime dt, int isDayOff)
        {
            Helper helper = new Helper();
            helper.ExecuteSqlCommand(String.Format("INSERT INTO TblPhtographerBusy (PhotographerID, BusyDate, IsDayOff) VALUES ({0}, '{1}', {2})", photographerID, dt.ToString("MM/dd/yyyy"), isDayOff));
            helper.Disconnect();
        }

        public static DataSet GetBusyTable()
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery("SELECT * FROM TblPhtographerBusy");
            helper.Disconnect();
            return ds;
        }

        public static void CancalBusyDay(int photographerId, DateTime dt)
        {
            Helper helper = new Helper();
            helper.ExecuteSqlCommand(String.Format(("Delete * From TblPhtographerBusy WHERE CONVERT(VARCHAR(10), BusyDate, 101) LIKE '{0}' AND photographerId={1}"), dt.ToString("MM/dd/yyyy"), photographerId));
            helper.Disconnect();
        }

        public static bool CheckPhotographerAvaliable(int photographerId, DateTime dt)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("SELECT * From TblPhtographerBusy WHERE CONVERT(VARCHAR(10), BusyDate, 101) LIKE '{0}' AND photographerId={1}"), dt.ToString("MM/dd/yyyy"), photographerId));
            helper.Disconnect();
            if (ds.Tables[0].Rows.Count == 0)
            {
                return true;
            }
            return false;
        }

        public static void SignUpForPhotographer(int photographerId)
        {
            Helper helper = new Helper();
            helper.ExecuteSqlCommand(String.Format("Select EventID, EventDate, PhotographerRating From TblEvents as e Join TblPhotographers as p on e.EventsPhotographer = {0})", photographerId));
            helper.Disconnect();
        }

        public static DataSet GetYesEvents(int photographerId)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("SELECT * From TblEventsAndPhotographers WHERE IsArrive LIKE 'Yes' AND PhotographerId={0}"), photographerId));
            helper.Disconnect();
            return ds;
        }

        public static DataSet GetMaybeEvents(int photographerId)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("SELECT * From TblEventsAndPhotographers WHERE IsArrive LIKE 'Maybe' AND PhotographerId={0}"), photographerId));
            helper.Disconnect();
            return ds;
        }

        public static DataColumn GetIdMaybeEvents(int photographerId)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("SELECT EventId From TblEventsAndPhotographers WHERE IsArrive LIKE 'Maybe' AND PhotographerId={0}"), photographerId));
            helper.Disconnect();
            return ds.Tables[0].Columns[0];
        }

        public static DataSet GetNoEvents(int photographerId)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("SELECT * From TblEventsAndPhotographers WHERE IsArrive LIKE 'No' AND PhotographerId={0}"), photographerId));
            
            helper.Disconnect();
            return ds;
        }

        public static int GetCloseEventId(int photographerId)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("SELECT EventId From TblEventsAndPhotographers WHERE IsArrive LIKE 'Yes' AND PhotographerId={0} ORDER BY CONVERT(VARCHAR(10), EventDate, 101) ASC"), photographerId));
            helper.Disconnect();
            return int.Parse(ds.Tables[0].Rows[0][0].ToString());
        }
    }
}
