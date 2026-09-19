using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Generation
{
    internal class Class2
    {
        
        public Class2()
        {
            Logger log = Logger.GetInstance();

            log.Log("Class2 was init");
            Console.WriteLine(log.GetHashCode());

        }
    }
}
