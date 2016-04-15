using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
  class ShaTar
  {
    public string description = "The Sha'tar, or 'born of light,' are naaru that aided the Aldor, the order of draenei priests formerly led by Velen, in rebuilding Shattrath City. The city was destroyed by the Orcs during their rampage across Draenor prior to the First War. The Aldor and the Scryers fight for the favor of the Sha'tar so that they may be assisted in their war by the naaru's powers. The entity that leads the Sha'tar is known as A'dal; he can be found upon the Terrace of Light in Shattrath City.";
    public string skin = "Sky Blue";
    public string clothing = "advanced space suite";
    public bool bigLungs = true;
    public int horns = 2;
    public bool advancedSpaceStation = true;
   
    private Spaceship _spaceship;

    public Spaceship spaceship
    {
      get
      {
        return _spaceship;
      }
      set
      {
        _spaceship = value;
      }
    }
  }
}

