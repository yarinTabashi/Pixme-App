using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BLProject2018;
namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WcfService2018" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WcfService2018.svc or WcfService2018.svc.cs at the Solution Explorer and start debugging.
    public class WcfService2018 : IWcfService2018
    {
        public List<string> GetMails()
        {
            Admin admin = new Admin();
            return admin.GetLess6Mails();
        }
    }
}