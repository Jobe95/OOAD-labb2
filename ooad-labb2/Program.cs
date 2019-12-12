using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ooadlabb2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press a key to fetch astronauts");
            Console.ReadKey();
            //IViewer viewer = new ConsoleViewer(new AstronautServices());
            //viewer.Load();
            IViewer viewer = new ConsoleViewer(new AstronautRepository());
            viewer.Load();
        }
    }
}