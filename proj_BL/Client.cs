using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalDBPro;
using System.Data; 

namespace BLFinalPro
{
    public class Client
    {
        protected int clientId;
        private string clientFirstName; 
        private string clientLastName; 
        private string clientPhoneNumber;
        private string clientUsername; 
        private string clientEmailAddress; 


        public Client()
        {
          this.clientId = 0;
          this.clientFirstName = ""; 
          this.clientLastName = ""; 
          this.clientPhoneNumber = "";  
          this.clientUsername = ""; 
          this.clientEmailAddress = ""; 
        }

        public bool SignIn(string clientUsername, string clientpass)
        {
            try
            {
                DataRow dr = ClientDal.LoginForClient(clientUsername, clientpass);

                this.clientId = int.Parse(dr["ClientID"].ToString());
                this.clientFirstName = dr["ClientFirstName"].ToString();
                this.clientLastName = dr["ClientLastName"].ToString();
                this.clientPhoneNumber = dr["ClientPhoneNumber"].ToString();
                this.clientEmailAddress = dr["ClientEmailAdress"].ToString();
                this.clientUsername = dr["ClientUsername"].ToString();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<string> GetListClientsNames()
        {
            List<string> clientsNamesLst = new List<string>();

            DataSet ds = ClientDal.GetClientsTable();
            for (int i = 0; i< ds.Tables[0].Rows.Count; i++)
            {
                clientsNamesLst.Add(ds.Tables[0].Rows[i]["ClientFirstName"].ToString());
            }

            return clientsNamesLst;
        }

        public bool SignInById(int clientId)
        {
            try
            {
                DataRow dr = ClientDal.GetClientRowByID(clientId);

                this.clientId = int.Parse(dr["ClientID"].ToString());
                this.clientFirstName = dr["ClientFirstName"].ToString();
                this.clientLastName = dr["ClientLastName"].ToString();
                this.clientPhoneNumber = dr["ClientPhoneNumber"].ToString();
                this.clientEmailAddress = dr["ClientEmailAdress"].ToString();
                this.clientUsername = dr["ClientUsername"].ToString();

                return true; 
            }
            catch
            {
                return false;
            }
        }

        public bool SignUpForClient(string clientFirstName, string clientLastName, string clientPhoneNumber, string clientEmailAdress, string clientUsername, string clientPassword)
        {
            try
            {
                ClientDal.SignUpForClient(clientFirstName, clientLastName, clientPhoneNumber, clientEmailAdress, clientUsername, clientPassword);

                SendRegisterNotificaition();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int GetClientId()
        {
            return this.clientId;
        }

        public string GetFullName()
        {
            string fullName = this.clientFirstName + " " + this.clientLastName + "";
            return fullName;
        }

        public string GetUsername()
        {
            return this.clientUsername;
        }

        public string GetPassword()
        {
            return ClientDal.GetClientPassword(this.clientId);
        }

        public void SetPassword(string newPassword)
        {
            ClientDal.SetClientPassword(newPassword, this.clientId);
        }

        public int CreateEvent(int eventNeedPhotographer, string eventName, string eventDescription, string eventDate, int eventType)
        {
            try
            {
                return EventsDal.CreateEvent(this.clientId, eventNeedPhotographer, eventName, eventDescription, eventDate, eventType);
            }
            catch
            {
                return 0;
            }
        }

        public bool ArrivalConfirmation(int eventId, string photoPermission)
        {
            try
            {
                EventsDal.UpdateMemberStatus(eventId, this.clientId, "Yes"); 
                EventsDal.UpdatePermission(eventId, this.clientId, photoPermission);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ArrivalDeny(int eventId, string photoPermission)
        {
            try
            {
                EventsDal.UpdateMemberStatus(eventId, this.clientId, "No");
                EventsDal.UpdatePermission(eventId, this.clientId, photoPermission);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int GetIdCloseEvent()
        {
            List<int> eventsLst = this.GetAllIdCloseEvents();
            return eventsLst[0];
        }

        public List<int> GetAllIdEvents()
        {
            DataSet events = null;
            List<int> eventsId = new List<int>();
            int tempId = 0;

            try
            {
                events = ClientDal.GetCloseEventId(this.clientId);

                for (int i = 0; i < events.Tables[0].Rows.Count; i++)
                {
                    tempId = int.Parse(events.Tables[0].Rows[i]["EventId"].ToString());
                    eventsId.Add(tempId);
                }

                return eventsId;
            }
            catch
            {
                return null;
            }
        }

        public List<int> GetAllIdCloseEvents()
        {
            DataSet events = null;
            DateTime tempDt = new DateTime();
            List<int> eventsIdsLst = null;

            eventsIdsLst = new List<int>();
            try
            {
                events = ClientDal.GetCloseEventId(this.clientId);

                for (int i = 0; i < events.Tables[0].Rows.Count; i++)
                {
                    tempDt = DateTime.ParseExact(events.Tables[0].Rows[i]["EventDate"].ToString(), "dd/MM/yyyy", null);
                    eventsIdsLst.Add(int.Parse(events.Tables[0].Rows[i]["EventId"].ToString()));
                    
                }

                return eventsIdsLst;
            }
            catch
            {
                return null;
            }
        }

        public bool SendRegisterNotificaition()
        {
            string body = "Hello " + this.GetFullName() + ",  \n\n 1 Your'e account created successfuly. \n\n  \n\n  Pixme Team, yarintabashi@gmail.com ";
            string subject = "Welcome to Pixmeapp";
            string to = this.clientEmailAddress;

            SendingNotifications send = new SendingNotifications();
            if (send.SendingMail(body, to, subject))
            {
                return true;
            }
            return false;
        }

        public string GetFirstName()
        {
            return this.clientFirstName;
        }

        public string GetLastName()
        {
            return this.clientLastName;
        }

        public string GetEmailAddress()
        {
            return this.clientEmailAddress;
        }

        public string GetPhoneNumber()
        {
            return this.clientPhoneNumber;
        }

        public void SetUsername(string newUsername)
        {
            ClientDal.SetClientUsername(newUsername, this.clientId);
        }

        public void SetEmailAddress(string newEmailAddress)
        {
            ClientDal.SetClientEmailAdress(newEmailAddress, this.clientId);
        }

        public void SetPhoneNum(string newPhoneNum)
        {
            ClientDal.SetClientPhoneNumber(newPhoneNum, this.clientId);
        }

        public bool SendPasswordToEmailAddress(string username)
        {
            try
            {
                string password = ClientDal.GetPasswordByUsername(username);
                string toEmail = ClientDal.GetEmailByUsername(username);

                SendingNotifications sendingNotifications = new SendingNotifications();
                sendingNotifications.SendingMail(password, toEmail, "Reset Your Password");

                return true;
            }
            catch
            {
                return false;
            }
        }

        public int GetIdLiveEvent()
        {
            DataSet events = null;
            DateTime tempDt = new DateTime();

            try
            {
                events = ClientDal.GetCloseEventId(this.clientId);

                for (int i = 0; i < (events.Tables[0].Rows.Count); i++)
                {
                    tempDt = DateTime.ParseExact(events.Tables[0].Rows[i]["EventDate"].ToString(), "dd/MM/yyyy", null);
                    if ((tempDt.Year == DateTime.Now.Year) && (tempDt.Month == DateTime.Now.Month) && (tempDt.Day == DateTime.Now.Day))
                    {
                        return int.Parse(events.Tables[0].Rows[i]["EventId"].ToString());
                    }
                }

                return 0;
            }
            catch
            {
                return 0;
            }
        }

        public List<int> GetAllClientsIds()
        {
            DataSet ds = ClientDal.GetAllClientsIds();
            List<int> clientsIds = new List<int>();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                clientsIds.Add(int.Parse(ds.Tables[0].Rows[i][0].ToString()));
            }

            return clientsIds;
        }

        public List<string> GetAllClientsNames()
        {
            DataSet ds = ClientDal.GetAllClientsNames();
            List<string> clientsNames = new List<string>();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                clientsNames.Add(ds.Tables[0].Rows[i][0].ToString() + " " + ds.Tables[0].Rows[i][1].ToString());
            }

            return clientsNames;
        }
       
        public void AddNewFriends(int clientIdTwo)
        {
            ClientDal.AddNewFriends(this.clientId, clientIdTwo);
        }

        public bool ClientsAreFriends(int clientIdTwo)
        {
            DataSet ds = ClientDal.AreFriends(this.clientId, clientIdTwo);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public List<int> GetAllClientFriendsIDs()
        {
            DataSet ds = ClientDal.GetAllFriendsIDsOfClient(this.clientId);
            List<int> friendsIDs = new List<int>();

            bool flag = true;

            if (int.Parse(ds.Tables[0].Rows[0][0].ToString()) == this.clientId)
            {
                flag = false;
            }

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (flag)
                {
                    friendsIDs.Add(int.Parse(ds.Tables[0].Rows[i][0].ToString()));
                }
                else
                {
                    friendsIDs.Add(int.Parse(ds.Tables[0].Rows[i][1].ToString()));
                }
            }

            return friendsIDs;
        }

        public List<string> GetAllClientFriendsNames()
        {
            List<int> friendsIDs = this.GetAllClientFriendsIDs();
            List<string> friendsNames = new List<string>();


            for (int i = 0; i < friendsIDs.Count; i++)
            {
                friendsNames.Add(ClientDal.GetFirstName(friendsIDs[i]) + " " + ClientDal.GetLastName(friendsIDs[i]));
            }

            return friendsNames;
        }

        public int GetCounterEventsParticipate()
        {
            DataColumn dc = ClientDal.GetEventsTotalClientParticipat(this.clientId);
            return dc.Table.Rows.Count;
        }

        public int GetCounterOwnEvents()
        {
            DataColumn dc = ClientDal.GetEventsClientCreated(this.clientId);
            return dc.Table.Rows.Count;
        }

        public int GetBestFriend()
        {
            DataColumn dc = ClientDal.GetBestFriend(this.clientId);

            if (dc.Table.Rows.Count == 0)
            {
                return 0;
            }

            if (int.Parse(dc.Table.Rows[0]["ClientId"].ToString()) != this.clientId)
            {
                return int.Parse(dc.Table.Rows[0]["ClientId"].ToString());
            }

            if (dc.Table.Rows.Count > 1)
            {
                return int.Parse(dc.Table.Rows[1]["ClientId"].ToString());
            }

            return 0;
        }
    }
}