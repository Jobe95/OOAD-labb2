using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ooadlabb2
{
    public class ConsoleViewer
    {
        private IAstronautRepository services;

        public ConsoleViewer(IAstronautRepository iAstronautRepository)
        {
            this.services = iAstronautRepository;
        }

        public void Load()
        {
            printCurrentAstronauts(services.GetAstronauts());
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
