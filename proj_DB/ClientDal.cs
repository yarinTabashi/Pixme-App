using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FinalDBPro
{
    public class ClientDal
    {
        public static void RemoveClient(int clientId)
        {
            Helper helper = new Helper();
            helper.ExecuteSqlCommand(String.Format("Delete From TblClients WHERE ClientID={0}", clientId));
            helper.Disconnect();
        }

        public static void SignUpForClient(string clientFirstName, string clientLastName, string clientPhoneNumber, string clientEmailAdress, string clientUsername, string clientPassword)
        {
            Helper helper = new Helper();
            helper.ExecuteSqlCommand(String.Format("INSERT INTO TblClients(ClientFirstName, ClientLastName, ClientPhoneNumber, ClientEmailAdress, ClientUsingRating, ClientUsername, ClientPassword) VALUES('{0}', '{1}', '{2}', '{3}', 5, '{3}', '{4}')", clientFirstName, clientLastName, clientPhoneNumber, clientEmailAdress, clientUsername, clientPassword));
            helper.Disconnect();
        }

        public static DataRow LoginForClient(string userName, string password)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("SELECT * From TblClients WHERE ClientUsername LIKE '{0}' AND ClientPassword LIKE \'{1}\'"), userName, password));
            helper.Disconnect();
            return ds.Tables[0].Rows[0];
        }

        public static DataSet GetClientsTable()
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery("SELECT * FROM TblClients");
            helper.Disconnect();
            return ds;
        }

        public static DataRow GetClientRowByID(int clientId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("SELECT * From TblClients WHERE ClientID={0}", clientId));
            helper.Disconnect();
            return ds.Tables[0].Rows[0];
        }

        public static string GetFirstName(int clientId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("SELECT ClientFirstName From TblClients WHERE ClientID={0}", clientId));
            helper.Disconnect();

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static string GetLastName(int clientId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("SELECT ClientLastName From TblClients WHERE ClientID={0}", clientId));
            helper.Disconnect();

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static string GetClientPhoneNumber(int clientId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("SELECT ClientPhoneNumber From TblClients WHERE ClientID={0}", clientId));
            helper.Disconnect();

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static string GetClientEmailAdress(int clientId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("SELECT ClientEmailAdress From TblClients WHERE ClientID={0}", clientId));
            helper.Disconnect();

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static int GetClientUsingRating(int clientId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("SELECT ClientUsingRating From TblClients WHERE ClientID={0}", clientId));
            helper.Disconnect();

            return int.Parse(ds.Tables[0].Rows[0][0].ToString());
        }

        public static string GetClientUsername(int clientId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("SELECT ClientUsername From TblClients WHERE ClientID={0}", clientId));

            helper.Disconnect();

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static string GetClientPassword(int clientId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery(String.Format("SELECT ClientPassword From TblClients WHERE ClientID={0}", clientId));
            helper.Disconnect();

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static void SetFirstName(string firstName, int clientId)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand((String.Format("UPDATE TblClients SET ClientFirstName='{0}' WHERE ClientID={1}", firstName, clientId)));
            helper.Disconnect();
        }

        public static void SetLastName(string lastName, int clientId)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand((String.Format("UPDATE TblClients SET ClientLastName='{0}' WHERE ClientID={1}", lastName, clientId)));
            helper.Disconnect();
        }

        public static void SetClientPhoneNumber(string phoneNumber, int clientId)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand((String.Format("UPDATE TblClients SET ClientPhoneNumber='{0}' WHERE ClientID={1}", phoneNumber, clientId)));
            helper.Disconnect();
        }

        public static void SetClientEmailAdress(string emailAdress, int clientId)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand((String.Format("UPDATE TblClients SET ClientEmailAdress='{0}' WHERE ClientID={1}", emailAdress, clientId)));
            helper.Disconnect();
        }

        public static void SetClientUsingRating(int usingRating, int clientId)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand((String.Format("UPDATE TblClients SET ClientUsingRating={0} WHERE ClientID={1}", usingRating, clientId)));
            helper.Disconnect();
        }

        public static void SetClientUsername(string userName, int clientId)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand((String.Format("UPDATE TblClients SET ClientUsername='{0}' WHERE ClientID={1}", userName, clientId)));
            helper.Disconnect();
        }

        public static void SetClientPassword(string passowrd, int clientId)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand((String.Format("UPDATE TblClients SET ClientPassword='{0}' WHERE ClientID={1}", passowrd, clientId)));
            helper.Disconnect();
        }
    
        public static DataSet GetOrderClientsTable()
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery("SELECT * FROM TblClients ORDER BY ClientID ASC");
            helper.Disconnect();

            return ds;
        }

        public static DataSet GetCloseEventId(int clientId)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("SELECT EventId, EventDate From TblEventsAndClients WHERE ClientId={0} ORDER BY CONVERT(VARCHAR(10), EventDate, 101) ASC"), clientId));
            helper.Disconnect();
            return ds;
        }

        public static string GetPasswordByUsername(string username)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("SELECT ClientPassword From TblClients WHERE ClientUsername LIKE \'{0}\'"), username));
            helper.Disconnect();
            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static string GetEmailByUsername(string username)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery(String.Format(("SELECT ClientEmailAdress From TblClients WHERE ClientUsername LIKE \'{0}\'"), username));
            helper.Disconnect();
            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static DataSet GetAllClientsIds()
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery("SELECT ClientID FROM TblClients");
            helper.Disconnect();
            return ds;
        }

        public static DataSet GetAllClientsNames()
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery("SELECT ClientFirstName, ClientLastName FROM TblClients");
            helper.Disconnect();
            return ds;
        }

        public static DataSet AreFriends(int firstClienId, int secondClientId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery((String.Format("Select FriendId From TblFriends WHERE FirstClientID={0} AND SecondClientID={1} OR FirstClientID={1} AND SecondClientID={0}", firstClienId, secondClientId)));
            helper.Disconnect();

            return ds;
        }

        public static void AddNewFriends(int firstClienId, int secondClientId)
        {
            Helper helper = new Helper();

            helper.ExecuteSqlCommand(String.Format("INSERT INTO TblFriends(FirstClientID, SecondClientID) VALUES({0}, {1})", firstClienId, secondClientId));
            helper.Disconnect();
        }

        public static DataSet GetAllFriendsIDsOfClient(int firstClienId)
        {
            Helper helper = new Helper();

            DataSet ds = helper.GetDataSetByQuery((String.Format("Select FirstClientID, SecondClientID From TblFriends WHERE FirstClientID={0} OR SecondClientID={0}", firstClienId)));
            helper.Disconnect();

            return ds;
        }

        public static DataColumn GetEventsTotalClientParticipat(int clientId)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery((String.Format("Select EventId From TblEventsAndClients WHERE IsArrive LIKE 'Yes' AND ClientId={0}", clientId)));
            helper.Disconnect();
            return ds.Tables[0].Columns[0];
        }

        public static DataColumn GetEventsClientCreated(int clientId)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery((String.Format("Select EventId From TblEvents Where EventMannagerID={0}", clientId)));
            helper.Disconnect();
            return ds.Tables[0].Columns[0];
        }

        public static DataColumn GetBestFriend(int clientId)
        {
            Helper helper = new Helper();
            DataSet ds = helper.GetDataSetByQuery((String.Format("Select ClientId From (Select EventMannagerID, ClientId FROM (Select TblEvents.EventID, TblEvents.EventMannagerID, TblEventsAndClients.ClientId From TblEvents JOIN TblEventsAndClients ON TblEvents.EventID = TblEventsAndClients.EventId) as e WHERE EventMannagerID={0}) as e group by ClientId order by COUNT(*) desc", clientId)));
            helper.Disconnect();
            return ds.Tables[0].Columns[0];
        }
    }
}