using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crea_Singleton
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Logger logger1 = Logger.Instance;
            logger1.Log("Application Started.");

            Logger logger2 = Logger.Instance;
            logger2.Log("user Logged in");

            Logger logger3 = Logger.Instance;
            logger3.Log("Order Created");

            Console.WriteLine();
            Console.WriteLine(
                $"logger1==logger2: {logger1==logger2}");

            Console.WriteLine(
                $"logger2==logger3: {logger2==logger3} ");

            Console.ReadKey();
        }
    }
}
