using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ooadlabb2
{
    public class AstronautRepository : IAstronautRepository
    {
        public List<Astronauts> People { get; set; }

        public IEnumerable<Astronauts> GetCurrentAstronauts()
        {
            var baseUrl = "http://api.open-notify.org/astros.json";
            var client = new WebClient();
            var json = client.DownloadString(baseUrl);
            client.Dispose();
            People = JsonConvert.DeserializeObject<AstronautRepository>(json).People;
            return People;
        }
    }
}
