using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Generation
{
    internal class Task : ITask
    {
        public string description { get; set; }

        public ITask Clone()
        {
            Task clone = new Task();
            clone.description = description;
            return clone;
        }

        public string SetDeskription()
        {
            return "Deskription" + description;
        }

        public override bool Equals(object obj)
        {
            return this.description.Equals(((Task)obj).description);
        }
    }
}
