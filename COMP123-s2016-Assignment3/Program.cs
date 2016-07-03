using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * @Author: Meer Zaheen Nazmul
 * @StudentNumber: 300522487
 * @DateCreated: July 3rd, 2016
 * @Description: Build and implement Planet classes and Interfaces
 * Version #: 0.0.1.2
 */

/**
 ********* REVISION *********
 * 1_ Initial Commit- Created Planet Diagram
 * Date: June 19th, 2016
 * 2_ Completed 1: a,b,c, and d and partial documentation
 * Date: June 19th, 2016
 * 3_ updated Planets class ToString Public Method
 * Date: June 19th, 2016
 * 4_ Completed 2: a, and b and revision
 * Date: June 19th, 2016
 * 5_ Completed 2: c, and revision
 * Date: June 19th, 2016
 * 6_Final Revision
 * Date: June 19th, 2016
 */
namespace COMP123_s2016_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("***************************************");
            GiantPlanet giantPlanet = new GiantPlanet("The Death Star", 3000000000, 5000000000, "Dark Matter");
            Console.WriteLine(giantPlanet.ToString());
            Console.WriteLine("***************************************");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Pluto", 1000, 4000, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
            waitForAnyKey();
        }
        public static void waitForAnyKey()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
