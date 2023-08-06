using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FinalDBPro
{
    public class EventsDal
    {
        public static int CreateEvent(int eventMannagerID, int eventNeedPhotographer, string eventName, string eventDescription, string eventDate, int eventType)
        {
            Helper helper = new Helper();

            helper.GetDataSetByQuery(String.Format(("INSERT INTO TblEvents (EventMannagerID, EventNeedPhotographer, EventName, EventDescription, EventDate, EventType) VALUES({0}, {1}, '{2}', '{3}', '{4}', {5})"), eventMannagerID, eventNeedPhotographer, eventName, eventDescription, eventDate, eventType));

            DataSet ds = helper.GetDataSetByQuery(String.Format("SELECT EventId From TblEvents EventId ORDER BY EventId DESC"));
            helper.Disconnect();
            return int.Parse(ds.Tables[0].Rows[0][0].ToString());
        }

        public static void InvitePhotographer(int eventId, int photographerId, string isArrive, string eventDate)
        {
            Helper helper = new Helper();

            helper.GetDataSetByQuery(String.Format(("INSERT INTO TblEventsAndPhotographers (EventId, PhotographerId, IsArrive, EventDate) VALUES({0}, {1}, '{2}', '{3}')"), eventId, photographerId, isArrive, eventDate));
        }

        public static string GetPhotographerStatusAboutEvent(int eventId, int photographerId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("Select IsArrive From TblEventsAndPhotographers WHERE EventId={0} AND PhotographerId={1}", eventId, photographerId));
            helper.Disconnect();
            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static void SetPotographerArriveStatus(int eventId, int photographerId, string arrivingStatus)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand(String.Format("UPDATE TblEventsAndPhotographers SET IsArrive='{0}' WHERE EventID={1} AND PhotographerId={2}", arrivingStatus, eventId, photographerId));
            helper.Disconnect();
        }

        public static void RemoveEventByEventID(int eventId)
        {
            Helper helper = new Helper();
            helper.ExecuteSqlCommand(String.Format("Delete From TblEvents WHERE EventID={0}", eventId));
            helper.Disconnect();
        }

        public static DataSet GetEventsTable()
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery("SELECT * FROM TblEvents");
            helper.Disconnect();
            return ds;
        }

        public static string GetEventDate(int eventId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("Select EventDate From TblEvents WHERE EventID={0}", eventId));
            helper.Disconnect();
            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static string GetEventName(int eventId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("Select EventName From TblEvents WHERE EventID={0}", eventId));
            helper.Disconnect();
            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static string GetEventDescription(int eventId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("Select EventDescription From TblEvents WHERE EventID={0}", eventId));
            helper.Disconnect();
            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static int GetEventBaseManager(int eventId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("Select EventMannagerID From TblEvents WHERE EventID={0}", eventId));
            helper.Disconnect();
            return int.Parse(ds.Tables[0].Rows[0][0].ToString());
        }

        public static int GetEventNeedPhotographer(int eventID)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("Select EventNeedPhotographer From TblEvents WHERE EventID={0}", eventID));
            helper.Disconnect();
            return int.Parse(ds.Tables[0].Rows[0][0].ToString());
        }

        public static DataSet EventsPhotographer()
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery("Select EventsPhotographer From TblEvents");
            helper.Disconnect();

            return ds;
        }

        public static void SetEventNeedPhotographer(int eventNeedPhotographer, int eventID)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand(String.Format("UPDATE TblEvents SET EventNeedPhotographer={0} WHERE EventID={1}", eventNeedPhotographer, eventID));
            helper.Disconnect();
        }

        public static void SetEventsPhotographer(int eventsPhotographer, int eventID)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand(String.Format("UPDATE TblEvents SET EventsPhotographer={0} WHERE EventID={1}", eventsPhotographer, eventID));
            helper.Disconnect();
        }

        public static void SetEventDescription(string eventDes, int eventID)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand(String.Format("UPDATE TblEvents SET EventDescription='{0}' WHERE EventID={1}", eventDes, eventID));
            helper.Disconnect();
        }

        public static void SetEventName(string eventName, int eventID)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand(String.Format("UPDATE TblEvents SET EventName='{0}' WHERE EventID={1}", eventName, eventID));
            helper.Disconnect();
        }

        public static void SetEventDate(DateTime dt, int eventId)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand(String.Format("UPDATE TblEvents SET EventDate='{0}' WHERE EventID={1}", dt.ToString("MM/dd/yyyy"), eventId));
            helper.Disconnect();
        }

        public static int SearchMemberStaus(int eventId, int memberId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("Select statusArrive From TblEventsAndClients WHERE EventID={0} AND ClientId={1}", eventId, memberId));
            helper.Disconnect();
            return int.Parse(ds.Tables[0].Rows[0][0].ToString());
        }

        public static void InviteMember(int eventId, int memberId, string photoPermission, string eventDate)
        {
            Helper helper = new Helper();

            helper.GetDataSetByQuery(String.Format(("INSERT INTO TblEventsAndClients (EventId, ClientId, IsArrive, photoPermission, EventDate) VALUES({0}, {1}, 'Maybe', '{2}', '{3}')"), eventId, memberId, photoPermission, eventDate));
        }

        public static void UpdateMemberStatus(int eventId, int clientId, string isArrive)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand(String.Format("UPDATE TblEventsAndClients SET IsArrive='{0}' WHERE EventId={1} AND ClientId={2}", isArrive, eventId, clientId));
            helper.Disconnect();
        }

        public static void UpdatePermission(int eventId, int memberId, string photoPermission)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand(String.Format("UPDATE TblEventsAndClients SET photoPermission='{0}' WHERE EventID={1} AND ClientId={2}", photoPermission, eventId, memberId));
            helper.Disconnect();
        }

        public static DataSet SearchMemberStaus()
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("Select statusArrive From TblEventsAndClients WHERE EventID={0} AND ClientId={1}"));
            helper.Disconnect();
            return ds;
        }

        public static DataSet GetImagesPaths(int eventId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format(("Select ImagePath From TblImages WHERE EventId={0}"), eventId));
            helper.Disconnect();
            return ds;
        }

        public static DataColumn GetAllEventTypes()
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery("Select EventType From TblEventType");
            helper.Disconnect();
            return ds.Tables[0].Columns[0];
        }

        public static string GetEventTypeByEventTypeId(int eventTypeId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format(("SELECT EventType From TblEventType WHERE EventTypeId={0}"), eventTypeId));
            helper.Disconnect();
            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static DataColumn GetTechnologicalIds()
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery("Select EventMannagerID From TblEvents WHERE EventType=1 OR EventType=2 OR EventType=3");
            helper.Disconnect();
            return ds.Tables[0].Columns[0];
        }
    }
}