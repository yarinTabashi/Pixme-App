using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BLProject2018;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWcfService2018" in both code and config file together.
    [ServiceContract]
    public interface IWcfService2018
    {
        [OperationContract]
        List<string> GetMails();
    }
}
