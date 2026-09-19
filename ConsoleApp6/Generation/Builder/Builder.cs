using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Generation.Builder
{
    internal class Builder
    {
        public void Run() 
        {
            Building building = new Worker().foundation("f")
                .walls("w")
                .roof("r")
                .interior("i")
                .build();
        }
    }
}
