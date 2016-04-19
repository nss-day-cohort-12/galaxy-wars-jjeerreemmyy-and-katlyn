using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
  class Vehicle
  {
    //Primary Vehicle class.
        //Override of Move() which can accept an overload to change how a spacecraft moves.
        public virtual string Move()
        {
            return "at a standstill";
        }
        public List<Draenei> pilots;
  }
}
