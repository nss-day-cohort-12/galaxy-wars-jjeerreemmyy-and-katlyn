using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
  class Vehicle
  {
        public virtual string Move()
        {
            return "at a standstill";
        }
        public List<Draenei> pilots;
  }
}
