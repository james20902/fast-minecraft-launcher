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
        private static readonly HttpClient webClient = new HttpClient();

        //Generate access token
        public static async Task<IServerResponse> sendRequest(IServerRequest requestPayload)
        {
            IServerResponse serverResponse = new ErrorPayload();
            webClient.BaseAddress = new Uri("https://authserver.mojang.com/");
            webClient.Timeout = TimeSpan.FromMilliseconds(5000);
            try
            {
                HttpResponseMessage response = await webClient.PostAsync(
                    requestPayload.getEndpoint(),
                    new StringContent(requestPayload.getPayload(), Encoding.UTF8, "application/json"));
                switch (requestPayload.getEndpoint())
                {
                    case ("authenticate"):
                        serverResponse = JsonConvert.DeserializeObject<AuthenticationResponse>(await response.Content.ReadAsStringAsync());
                        break;
                }

                return serverResponse;

            }
            catch (TimeoutException timeout)
            {
                return new ErrorPayload();
            }
            catch (HttpRequestException requestException)
            {
                return new ErrorPayload();
            }
        }
      
    }
}
