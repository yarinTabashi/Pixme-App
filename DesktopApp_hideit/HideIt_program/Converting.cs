using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideItWF
{
    public static class Converting
    {
        public static Bitmap Convert(string url)
        {
            WebRequest request = WebRequest.Create(url);
            using (var response = request.GetResponse())
            {
                using (var str = response.GetResponseStream())
                {
                    Bitmap bit = new Bitmap(Bitmap.FromStream(str));
                    return bit;
                }
            }
        }
    }
}