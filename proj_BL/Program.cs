using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLFinalPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.SignInById(4);
            Console.WriteLine(client.GetBestFriend());
        }
    }
}
