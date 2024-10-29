using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTraining
{
    internal class Bunnyficator
    {
        public string Name { get; set; }
        public double Roundness { get; set; }
        public Bunnyficator(object o, double roundess) 
        {
            Name = o.GetType().ToString();
            Roundness = roundess;
        }

        public override string ToString()
        {

            return $"{Name}, {Roundness}, {base.ToString()}";
        }
    }
}
