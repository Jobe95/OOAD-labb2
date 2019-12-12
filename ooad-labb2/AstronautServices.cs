using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using System.Linq;

namespace ooadlabb2
{
    public class AstronautServices : IAstronautService
    {
        public IEnumerable<Astronauts> GetAstronauts()
        {
            AstronautRepository astronautRepository = new AstronautRepository();
            return astronautRepository.GetCurrentAstronauts();
        }
    }
}