using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ooadlabb2
{
    public class AstronautRepository : IAstronautRepository
    {
        public List<Astronauts> People { get; set; }

        public IEnumerable<Astronauts> GetAstronauts()
        {
            AstronautServices services = new AstronautServices();
            People = services.GetCurrentAstronauts();
            return People;
        }
    }
}
