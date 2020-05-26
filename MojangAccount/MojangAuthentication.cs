using System.IO;
using System.Net;
using fast_minecraft_launcher.MojangAccount;

namespace fast_minecraft_launcher
{

    class MojangAuthentication
    {
        IServerResponse response;

        //Generate access token
        public void authenticate(string user, string pass)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://authserver.mojang.com/authenticate");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                
            }
        }
      
    }
}
