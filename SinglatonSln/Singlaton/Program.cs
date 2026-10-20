using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlaton
{
    class Logger
    {
        private static Logger instance;

        private Logger() { } // for bahire theke new kora jabe na 

        public static Logger GetInstance()
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }

        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger a = Logger.GetInstance();
            Logger b = Logger.GetInstance();

            a.Log("Mahfuj");
            b.Log("Rahman");
            Console.WriteLine(a == b); //true
            Console.WriteLine(b == a);
        }
    }
}
