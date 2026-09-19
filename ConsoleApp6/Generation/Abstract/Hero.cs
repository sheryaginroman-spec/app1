using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Generation.Abstract
{
    internal class Hero
    {
        public string Name { get; }
        public IHit hit;
        public IMove move;

        public Hero(string name, IHit hit, IMove move)
        {
            Name = name;
            this.hit = hit;
            this.move = move;
        }

        public void Hit()
        {
            Console.Write(Name);
            Console.Write(' ');

            hit.Hit();
        }
        public void Move()
        {
            Console.Write(Name);
            Console.Write(' ');

            move.Move();
        }


    }
}
