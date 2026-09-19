using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Generation
{
    internal class Class1
    {
        public Class1()
        {
            Logger log = Logger.GetInstance();
            log.Log("Class1 was init");
            Console.WriteLine(log.GetHashCode());
        }
    }
}
