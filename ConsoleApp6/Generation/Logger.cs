using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Generation
{
    internal class Logger
    {
        public static Logger Instance = new Logger();
        private Logger() { }
        public static Logger GetInstance() 
        {
            return Instance;
        } 

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
