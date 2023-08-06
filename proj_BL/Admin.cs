using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalDBPro;
using System.Data;

namespace BLFinalPro
{
    public class Admin
    {
        public List<string> GetEmailsOfTechonlogicalEvents()
        {
            DataColumn dc = EventsDal.GetTechnologicalIds();
            List<int> peopleToSendIds = new List<int>();
            List<string> peopleToSendEmails = new List<string>();
            Client client = null;

            for (int i = 0; i < dc.Table.Rows.Count; i++)
            {
                peopleToSendIds.Add(int.Parse((dc.Table.Rows[i][0].ToString())));
            }

            for (int i = 0; i < peopleToSendIds.Count; i++)
            {
                client = new Client();
                client.SignInById(peopleToSendIds[i]);
                peopleToSendEmails.Add(client.GetEmailAddress());
            }

            return peopleToSendEmails;
        }
    }
}
