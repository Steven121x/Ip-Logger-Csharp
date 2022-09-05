using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IP_LOGGER
{
    internal class connection
    {
        public static byte[] post(string uri, NameValueCollection pair)
        {
            using (WebClient wc = new WebClient())
            {
                return wc.UploadValues(uri, pair);
            }
        }
    }
}
