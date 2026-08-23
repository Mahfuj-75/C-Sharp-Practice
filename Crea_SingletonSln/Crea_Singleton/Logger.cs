using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crea_Singleton
{
    public sealed class Logger
    {
        private static Logger _instance;
        private Logger()
        {

        }
        public static Logger Instance // ekta shared instance return kore
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(
                $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
        }
    }
           
}
