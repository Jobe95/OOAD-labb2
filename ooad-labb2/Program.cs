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
            ConsoleViewer consoleViewer = new ConsoleViewer(new AstronautServices());
            consoleViewer.Load();
            
            
            
            
            //foreach (Astronauts i in list)
            //{
            //    Console.WriteLine(i.name);
            //    Console.WriteLine(i.craft);
            //}
            
        }
    }
}