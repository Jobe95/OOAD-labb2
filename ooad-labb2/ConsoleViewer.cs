using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
namespace ooadlabb2
{
    public class ConsoleViewer : IViewer
    {
        private readonly IAstronautRepository astronautRepository;

        public ConsoleViewer(IAstronautRepository iAstronautRepository)
        {
            this.astronautRepository = iAstronautRepository;
        }

        public void Load()
        {
            printCurrentAstronauts(astronautRepository.GetAstronauts().ToList());
        }

        public void printCurrentAstronauts(List<Astronauts> CurrentAstronauts)
        {
            Console.WriteLine("Number of persons in space: {0}", CurrentAstronauts.Count);
            foreach (var astronaut in CurrentAstronauts)
            {
                Console.WriteLine("Name: {0}, Craft: {1}", astronaut.name, astronaut.craft);
            }
        }
    }
}
