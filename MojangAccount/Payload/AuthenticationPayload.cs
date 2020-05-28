using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace fast_minecraft_launcher.MojangAccount.Payload
{
    class AuthenticationPayload : IServerRequest
    {
        public Dictionary<string, Object> agent;
        public string username;
        public string password;
        // public string clientToken;

        public AuthenticationPayload(string username, string password)
        {
            agent = new Dictionary<string, object>();
            agent.Add("name", "Minecraft");
            agent.Add("version", 1);
            this.username = username;
            this.password = password;
        }

        public string getEndpoint()
        {
            return "authenticate";
        }

        public string getPayload()
        {
            return JsonConvert.SerializeObject(this);
        }


    }
}
