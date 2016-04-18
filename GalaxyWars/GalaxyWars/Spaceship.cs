using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
  class Spaceship : Vehicle
  {
    public string name = "Spaceship";
    public bool evasive = true;
    public bool lasers = true;
    public override string Move()
        {
            return "light speed";
        }
    }
}
