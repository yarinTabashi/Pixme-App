using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FinalProjService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPhotographerService" in both code and config file together.
    [ServiceContract]
    public interface IPhotographerService
    {
        [OperationContract]
        string GetPhotographerFirstName(string photographerUsername, string photogrpaherPassword);

        [OperationContract]
        string GetPhotographerLastName(string photographerUsername, string photogrpaherPassword);

        [OperationContract]
        string GetPhotographerEmail(string photographerUsername, string photogrpaherPassword);
    }
}
