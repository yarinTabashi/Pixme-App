using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BLFinalPro;

namespace FinalProjService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PhotographerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PhotographerService.svc or PhotographerService.svc.cs at the Solution Explorer and start debugging.
    public class PhotographerService : IPhotographerService
    {
        public string GetPhotographerFirstName(string photographerUsername, string photogrpaherPassword)
        {
            Photographer thePhotographer = new Photographer();
            thePhotographer.PhotographerSignIn(photographerUsername, photogrpaherPassword);
            return thePhotographer.GetFirstName();
        }

        public string GetPhotographerLastName(string photographerUsername, string photogrpaherPassword)
        {
            Photographer thePhotographer = new Photographer();
            thePhotographer.PhotographerSignIn(photographerUsername, photogrpaherPassword);
            return thePhotographer.GetLastName();
        }

        public string GetPhotographerEmail(string photographerUsername, string photogrpaherPassword)
        {
            Photographer thePhotographer = new Photographer();
            thePhotographer.PhotographerSignIn(photographerUsername, photogrpaherPassword);
            return thePhotographer.GetEmailAddress();
        }
    }
}
