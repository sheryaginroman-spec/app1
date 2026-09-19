using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Generation.Abstract
{
    internal class Run : IMove
    {
        public void Move()
        {
            Console.WriteLine("i run");
        }
    }
}
