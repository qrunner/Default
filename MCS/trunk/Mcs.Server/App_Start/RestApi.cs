using Newtonsoft.Json;

namespace Mcs.Server.App_Start
{
    public static class RestApi
    {
        public static T GetData<T>(string uri)
        {
            System.Net.WebClient webClient = new System.Net.WebClient();
            webClient.Headers.Add("Content-Type", "text/plain; charset=utf-8");
            var json = webClient.DownloadString(uri);            
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}