using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using fast_minecraft_launcher.MojangAccount;
using fast_minecraft_launcher.MojangAccount.Payload;
using Newtonsoft.Json;

namespace fast_minecraft_launcher
{

    class MojangAuthentication
    {
        private static MojangAuthentication instance;

        public static MojangAuthentication getInstance()
        {
            if (instance == null)
            {
                instance = new MojangAuthentication();
            }

            return instance;
        }

        private static HttpClient webClient;

        public MojangAuthentication()
        {
            webClient = new HttpClient();
            webClient.BaseAddress = new Uri("https://authserver.mojang.com/");
            webClient.Timeout = TimeSpan.FromMilliseconds(5000);
        }

        private async Task<string> SendRequest(IServerRequest requestPayload)
        {
            try
            {
                HttpResponseMessage response = await webClient.PostAsync(
                    requestPayload.getEndpoint(),
                    new StringContent(requestPayload.getPayload(), Encoding.UTF8, "application/json"));
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                return await response.Content.ReadAsStringAsync();
            }
            catch (TimeoutException e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }

        }

        public async Task<AuthenticationResponse> GetAuthenticationResponse(AuthenticationPayload payload)
        {
            return JsonConvert.DeserializeObject<AuthenticationResponse>(await SendRequest(payload));
        }
    }
}
