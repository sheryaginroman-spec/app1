using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Generation.Abstract
{
    internal class HeroFactory
    {
        public static Hero CreateRanger()
        {
            return new Hero("ranger", new Shoot(), new Run());
        }

        public static Hero CreatePudge()
        {
            return new Hero("Pudge", new Swing(), new Run());
        }

        public static Hero CreateViper()
        {
            return new Hero("Viper", new Shoot(), new Fly());
        }
        public static Hero Createiq()
        {
            return new Hero ("iq",new Wizard(), new Polzat());
        }
    }
}
