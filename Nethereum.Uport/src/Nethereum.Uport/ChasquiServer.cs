using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nethereum.Uport
{
    public class UportChasquiServer
    {
        private string chasquiServerUrl;
        public UportChasquiServer(string chasquiServerUrl)
        {
            this.chasquiServerUrl = chasquiServerUrl;
        }

        public Topic NewTopic(string topicName)
        {
            return Topic.NewTopic(chasquiServerUrl, topicName);
        }

        public async Task<JObject> GetResponseAsync(Topic topic)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(topic.Url);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return JObject.Parse(result);
            }
            throw new HttpRequestException("Error: " + response.StatusCode);
        }

        public async Task<HttpResponseMessage> ClearRequestAsync(Topic topic)
        {
            var httpClient = new HttpClient();
            return await httpClient.DeleteAsync(topic.Url);
        }
    }

}
