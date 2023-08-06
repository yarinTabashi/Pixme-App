using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BLFinalPro;

namespace ProjectWCFProvider
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "wcfprovider" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select wcfprovider.svc or wcfprovider.svc.cs at the Solution Explorer and start debugging.
    public class wcfprovider : Iwcfprovider
    {
        public List<string> GetEmailsOfTechonlogicalEvents()
        {
            Admin admin = new Admin();
            return admin.GetEmailsOfTechonlogicalEvents();
        }
    }
}
