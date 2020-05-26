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
        private IDictionary<string, Object> agent;
        private string username;
        private string password;
        private string clientToken;

        public AuthenticationPayload(string username, string password)
        {
            agent.Add("name", "Minecraft");
            agent.Add("version", 1);
            this.username = username;
            this.password = password;
        }

        public string getEndpoint()
        {
            return "/authenticate";
        }

        public string getPayload()
        {
            return JsonConvert.SerializeObject(this);
        }


    }
}
