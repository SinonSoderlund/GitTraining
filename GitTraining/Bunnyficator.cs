using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTraining
{
    internal class Bunnyficator
    {
        public string Name { get;  }
        public double Roundness { get;}
        private object _object;

        /// <summary>
        /// Creates a bunny from an object
        /// </summary>
        /// <param name="o">object thats gonna be bouny :)</param>
        /// <param name="roundess">how round is the bunny?</param>
        public Bunnyficator(object o, double roundess)
        {
            Name = o.GetType().ToString();
            Roundness = roundess;
            _object = o;
        }
        /// <summary>
        /// String represented bunny
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return $"{Name}, {Roundness}, {base.ToString()}";
        }

        /// <summary>
        /// Why would you do that to the pooor bunny :(
        /// </summary>
        /// <returns>returns the bunnys inner object</returns>
        public object GetObject()
        {
            return _object;
        }
    }
}