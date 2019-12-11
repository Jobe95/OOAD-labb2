using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using System.Linq;

namespace ooadlabb2
{
    public class AstronautServices : IAstronautRepository
    {

        public IEnumerable<Astronauts> GetAstronauts()
        {
            var baseUrl = "http://api.open-notify.org/astros.json";
            var client = new WebClient();
            var json = client.DownloadString(baseUrl);
            client.Dispose();
            return JsonConvert.DeserializeObject<AstronautHelper>(json).People;
        }
    }
}