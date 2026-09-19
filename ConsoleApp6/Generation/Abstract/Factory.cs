using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Generation.Abstract
{
    internal class Factory
    {
        public static void Run()
        {
            Hero pudge = HeroFactory.CreatePudge();
            Hero viper = HeroFactory.CreateViper();

            Hero ranger = HeroFactory.CreateRanger();
            Hero io = HeroFactory.Createiq();

            pudge.Hit();
            viper.Hit();
            ranger.Hit();

            pudge.Move();
            viper.Move();
            ranger.Move();

            io.Hit();
            io.Move();


        }
    }
}
