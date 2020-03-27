using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Examen_BGlobal.Services
{
    public class RestClient
    {
        private WebClient client;
        private string json;

        public RestClient(string url)
        {
            json = new WebClient().DownloadString(url);
        }
        
        public dynamic GetObject()
        {
            return JsonConvert.DeserializeObject(json);
        }

    }
}