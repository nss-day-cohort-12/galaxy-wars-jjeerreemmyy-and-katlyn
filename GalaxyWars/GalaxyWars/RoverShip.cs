using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
  class RoverShip : Vehicle
  {
    public string name = "Rover Ship";
    public bool canDrill = true;
    public int gunTurrets = 10;
    public override string Move()
        {
            return "Warp speed";
        }
    }
}
