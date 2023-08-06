using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalDBPro;
using System.Data;

namespace BLFinalPro
{
    public class Photographer
    {
        private int photographerId; 
        private string firstName;
        private string lastName; 
        private string emailAddress; 
        private string photographerUsername = ""; 
        private string photographerPassword = "";

        public Photographer()
        {
            this.photographerId = 0;
            this.firstName = ""; 
            this.lastName = "";
            this.emailAddress = ""; 
            this.photographerUsername = ""; 
            this.photographerPassword = ""; 
        }

        public bool SignInById(int photographerId)
        {
            try
            {
                DataRow dr = PhotographerDal.LoginForPhotographer(photographerId);

                this.photographerId = int.Parse(dr["PhotographerID"].ToString());
                this.firstName = dr["PhotographerFirstName"].ToString();
                this.emailAddress = dr["PhotographerEmailAddress"].ToString();
                this.photographerUsername = dr["PhotographerUsername"].ToString();
                this.photographerUsername = dr["PhotographerPassword"].ToString();

                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool PhotographerSignIn(string photographerUsername, string photographerPassword)
        {
            try
            {
                DataRow dr = PhotographerDal.LoginForPhotographer(photographerUsername, photographerPassword);

                this.photographerId = int.Parse(dr["PhotographerID"].ToString());
                this.firstName = dr["PhotographerFirstName"].ToString();
                this.emailAddress = dr["PhotographerEmailAddress"].ToString();
                this.photographerUsername = photographerUsername;
                this.photographerPassword = photographerPassword;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool PhotographerSignUp(string photographerFirstName, string photographerLastName, string photographerPhoneNumber, string photographerEmailAddress, int photographerRating, string photographerUsername, string photographerPassword)
        {
            try
            {
                PhotographerDal.SignUpForPhotographer(photographerFirstName, photographerLastName, photographerPhoneNumber, photographerEmailAddress, photographerRating, photographerUsername, photographerPassword);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GetNameById()
        {
            return PhotographerDal.GetFirstNameById(this.photographerId);
        }

        public string GetFullName()
        {
            return (this.firstName + " " + this.lastName);
        }

        public int GetPhotographerId()
        {
            return this.photographerId;
        }


        public void ChangeToDayoff(DateTime dt) 
        {
            PhotographerDal.AddBusyDate(this.photographerId, dt, 1);
        }

        public void ChangeToBusy(DateTime dt) 
        {
            PhotographerDal.AddBusyDate(this.photographerId, dt, 0);
        }


        public void CanalTheBusyDay(DateTime dt)
        {
            PhotographerDal.CancalBusyDay(this.photographerId, dt);
        }

        public bool CheckAvaliable(DateTime dt)
        {
            return PhotographerDal.CheckPhotographerAvaliable(this.photographerId, dt);
        }


        public bool ConfirmEvent(int eventID) 
        {
            Event ev = new Event(eventID);
            DateTime eventDt = ev.GetEventDate();
            if (CheckAvaliable(eventDt) == true)
            {
                try
                {
                    ChangeToBusy(eventDt);    
                    EventsDal.SetPotographerArriveStatus(eventID, this.photographerId, "Yes");
                    return true; 
                }
                catch
                {
                    return false;
                }
            }
            return false; 
        }

        public bool DontConfirmEvent(int eventID)
        {
            try
            {
                Event ev = new Event(eventID);
                DateTime eventDt = ev.GetEventDate();
                CanalTheBusyDay(ev.GetEventDate());   
                EventsDal.SetPotographerArriveStatus(eventID, this.photographerId, "No");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int GetIdCloseEvent()
        {
            try
            {
                int result = PhotographerDal.GetCloseEventId(this.photographerId);

                return result;
            }
            catch
            {
                return 0;
            }
        }

        public int GetCounterNoEvnets()
        {
            int result = 0;
            try
            {
                DataSet ds = PhotographerDal.GetNoEvents(this.photographerId);
                result = int.Parse(ds.Tables[0].Rows.Count.ToString());
                return result;
            }
            catch
            {
                return 0;
            }
        }

        public int GetCounterYesEvnets()
        {
            int result = 0;
            try
            {
                DataSet ds = PhotographerDal.GetYesEvents(this.photographerId);
                result = int.Parse(ds.Tables[0].Rows.Count.ToString());
                return result;
            }
            catch
            {
                return 0;
            }
        }

        public List<int> GetEventIdYesUpcoming()
        {
            List<int> eventsLst = new List<int>();

            DataSet ds = PhotographerDal.GetYesEvents(this.photographerId);

            try
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if (DateTime.Parse(row["EventDate"].ToString()).CompareTo(DateTime.Today) > 0)
                    {
                        eventsLst.Add(int.Parse(row["EventId"].ToString()));
                    }
                }

                return eventsLst;
            }
            catch
            {
                return null;
            }
        }

        public List<string> GetEventNamesYesUpcoming()
        {
            List<int> eventsIdLst = this.GetEventIdYesUpcoming();
            List<string> eventsNamesLst = new List<string>();
            Event tempEvent = null;

            try
            {
                for (int i = 0; i < eventsIdLst.Count; i++)
                {
                    tempEvent = new Event(eventsIdLst[i]);
                    eventsNamesLst.Add(tempEvent.GetEventName());
                }

                return eventsNamesLst;
            }
            catch
            {
                return null;
            }
        }

        public int GetCounterYesUpcoming()
        {
            try
            {
                return this.GetEventIdYesUpcoming().Count;
            }
            catch
            {
                return 0;
            }
        }

        public DataSet GetDataSetOfUpcomingEvents()
        {
            DataSet ds = PhotographerDal.GetYesEvents(this.photographerId);
            List<int> eventsIdLst = new List<int>();
            DataSet finalDs = EventsDal.GetEventsTable();
            bool flag = false;
            int counterDelets = 0;

            try
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (DateTime.Parse(ds.Tables[0].Rows[i]["EventDate"].ToString()).CompareTo(DateTime.Today) > 0)
                    {
                        eventsIdLst.Add(int.Parse(ds.Tables[0].Rows[i]["EventId"].ToString()));
                    }
                }

                for (int j = 0; j <= finalDs.Tables[0].Rows.Count; j++) 
                {
                    for (int i = 0; i < eventsIdLst.Count; i++)
                    {
                        if (int.Parse(finalDs.Tables[0].Rows[j - counterDelets]["EventId"].ToString()) == eventsIdLst[i])
                        {
                            flag = true;
                        }
                    }

                    if (!flag)
                    {
                        finalDs.Tables[0].Rows.RemoveAt(j - counterDelets);
                        counterDelets++;
                    }

                    flag = false;
                }

                return finalDs;
            }
            catch
            {
                return null;
            }
        }


        public int GetCounterMaybeEvnets()
        {
            int result = 0;
            try
            {
                DataSet ds = PhotographerDal.GetMaybeEvents(this.photographerId);
                result = int.Parse(ds.Tables[0].Rows.Count.ToString());
                return result;
            }
            catch
            {
                return 0;
            }
        }

        public DataSet GetMaybeEvents()
        {
            try
            {
                DataSet ds = PhotographerDal.GetMaybeEvents(this.photographerId);
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public List<int> GetIdMaybeEvents()
        {
            List<int> listOfEventsNames = new List<int>();
            DataColumn dc = PhotographerDal.GetIdMaybeEvents(this.photographerId);

            try
            {
                foreach (DataRow row in dc.Table.Rows)
                {
                    listOfEventsNames.Add(int.Parse(row[0].ToString()));
                }

                return listOfEventsNames;
            }
            catch
            {
                return null;
            }
        }

        public List<string> GetNamesMaybeEvents()
        {
            List<string> listOfEventsNames = new List<string>();
            DataColumn dc = PhotographerDal.GetIdMaybeEvents(this.photographerId);
            int tempEventId = 0;

            try
            {
                foreach (DataRow row in dc.Table.Rows)
                {
                    tempEventId = int.Parse(row[0].ToString());
                    Event newEvent = new Event(tempEventId);
                    listOfEventsNames.Add(newEvent.GetEventName());
                }

                return listOfEventsNames;
            }
            catch
            {
                return null;
            }
        }


        public int GetCloseEventId()
        {
            int eventId = 0;
            DateTime todayDate = System.DateTime.Today;
            DateTime eventDate;

            try
            {
                eventId = PhotographerDal.GetCloseEventId(this.photographerId);
                eventDate = DateTime.Parse(EventsDal.GetEventDate(eventId));

                if (eventDate.CompareTo(todayDate) > 0)
                {
                    return eventId;
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }

        public bool AddPictureForProfitolo(string picturePath)
        {
            try
            {
                PictureDal.AddImageForProfitolo(picturePath, this.photographerId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SetImageFromEventToProfitolo(int imageId)
        {
            try
            {
                PictureDal.SetImageFromEventToProfitolo(imageId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataSet GetProfitolo()
        {
            try
            {
                DataSet ds = PictureDal.GetPhotographerProfitolo(this.photographerId);
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public List<int> GetProfitoloIds()
        {
            List<int> picturesIdLst = new List<int>();
            DataSet ds = this.GetProfitolo();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                picturesIdLst.Add(int.Parse(row["ImageID"].ToString()));
            }

            return picturesIdLst;
        }

        public List<string> GetProfitoloPath()
        {
            List<string> picturesPathLst = new List<string>();
            DataSet ds = this.GetProfitolo();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                picturesPathLst.Add(row["ImagePath"].ToString());
            }

            return picturesPathLst;
        }

        public DataSet GetMyAllImages()
        {
            try
            {
                DataSet ds = PictureDal.GetAllImagesOfPhotographer(this.photographerId);
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public string GetEmailAddress()
        {
            return this.emailAddress;
        }

        public string GetUsername()
        {
            return this.photographerUsername;
        }

        public string GetPassword()
        {
            return this.photographerPassword;
        }
    }
}
