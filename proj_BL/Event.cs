using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalDBPro;
using System.Data;

namespace BLFinalPro
{
    public class Event
    {

        private int eventId; 
        private int baseEventMangaer; 
        private DateTime eventDate; 
        private string eventName;

        public Event(int eventMangagerId, int eventNeedPhotographer, string eventName, string eventDesc, string eventDate, int eventType)
        {
            int idOfEvent = 0;
            idOfEvent = EventsDal.CreateEvent(eventMangagerId, eventNeedPhotographer, eventName, eventDesc,eventDate, eventType);

            this.eventId = idOfEvent;
            this.eventName = eventName;
            this.eventDate = DateTime.ParseExact(eventDate, "dd/M/yyyy", null);
            this.baseEventMangaer = eventMangagerId;
        }

        public Event(int eventId)
        {
            this.eventId = eventId;
            string eventDate = EventsDal.GetEventDate(eventId);
            this.eventDate = DateTime.ParseExact(eventDate, "dd/M/yyyy", null);
            this.eventName = EventsDal.GetEventName(eventId);
            this.baseEventMangaer = EventsDal.GetEventBaseManager(eventId);
        }

        public int GetEventId()
        {
            return this.eventId;
        }

        public string GetEventName()
        {
            return this.eventName;
        }

        public string GetEventDescription()
        {
            return EventsDal.GetEventDescription(this.eventId);
        }

        public DateTime GetEventDate()
        {
            return this.eventDate;
        }

        public int GetEventBaseManager()
        {
            return this.baseEventMangaer;
        }

        public void SetEventDate(DateTime newDt)
        {
            EventsDal.SetEventDate(newDt, this.eventId);
            this.eventDate = newDt;
        }

        public int SuggestAvailablePhotographer()
        {
            List<int> potenialPhotographer = new List<int>();

            DataSet allPhDS = PhotographerDal.GetAllPhotographers();

            bool isAvalible = false;

            for (int i = 0; i < allPhDS.Tables[0].Rows.Count; i++)
            {
                isAvalible = false;
                isAvalible = (PhotographerDal.CheckPhotographerAvaliable(int.Parse(allPhDS.Tables[0].Rows[i][0].ToString()), this.eventDate));
                if (isAvalible)
                {                  
                    return int.Parse(allPhDS.Tables[0].Rows[i][0].ToString());
                }
            }

            return 0;
        }

        public double GetDaysLeft()
        {
            double totalDays = (this.eventDate - DateTime.Today).TotalDays;
            if (totalDays < 0)
            {
                return -1;
            }
            return totalDays;
        }

        public string GetStatusOfPhotographerAboutEvent(int photographerId)
        {
            string photographerStatus = "";

            try
            {
                photographerStatus = EventsDal.GetPhotographerStatusAboutEvent(this.eventId, photographerId);
                return photographerStatus;
            }
            catch
            {
                return "";
            }
        }

        public bool AddPictureFromTheEvent(int photographerId, string picturePath)
        {
            try
            {
                PictureDal.AddImageFromEvent(picturePath, photographerId, this.eventId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddPictureFromTheEventForClient(int clientId, string picturePath)
        {
            try
            {
                PictureDal.AddImageFromEventClient(picturePath, clientId, this.eventId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InvitePhotographer(int photographerId)
        {
            try
            {
                EventsDal.InvitePhotographer(this.eventId, photographerId, "Maybe", this.eventDate.ToShortDateString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InviteMember(int clientId)
        {
            Event ev = new Event(eventId);
            string eventDt = ev.GetEventDate().ToString("dd/M/yyyy");

            try
            {
                EventsDal.InviteMember(this.eventId, clientId, "NoReply", eventDt);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int RemainingDaysUntilEvent()
        {
            return (int)(DateTime.Now - this.eventDate).TotalDays;
        }

        public List<string> GetAllImagesPaths()
        {
            DataSet ds = EventsDal.GetImagesPaths(this.eventId);
            List<string> paths = new List<string>();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                paths.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            return paths;
        }      
    }
}