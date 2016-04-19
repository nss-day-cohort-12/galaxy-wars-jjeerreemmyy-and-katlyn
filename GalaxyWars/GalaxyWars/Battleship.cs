using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
    class Battleship : Vehicle
    {
    public string name = "Battleship";
    public bool hasForceFields = true;
    public bool hasInvisibilty = true;
    public override string Move()
        {
            return "Hyersonic speed";
        }
    }
}
