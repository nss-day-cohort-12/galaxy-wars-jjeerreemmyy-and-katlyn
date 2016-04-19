using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
  //Murkblood is a Draenei and is the warmongering species.
  class MurkBlood : Draenei, IWarfare
  {
    //Overloads the description for the MurkBlood class of Draenei.
    public override string Desc()
        { return "Murkblood, the hostile tribe of broken Draenei.\n"; }
    public string skin = "Green";
    public string clothing = "Battle Armor"; 
    public string bodyType = "Large, Hunched, Muscular";
    public bool filteredBreathing = true;
    public int horns = 3;
    public int startingPopulation = 1000000;

    public bool violent()
    {
      return true;
    }

    public string weaponSpecialty()
    {
      return "Electric Steel";
    }

    public bool undergroundBarracks()
    {
      return true;
    }

  }
}
