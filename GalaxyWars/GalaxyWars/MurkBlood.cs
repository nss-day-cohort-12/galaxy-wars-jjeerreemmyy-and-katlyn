﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
  class MurkBlood : Draenei, IWarfare
  {
    public string description = "Murkblood, the hostile tribe of broken Draenei.";
    public string skin = "Green";
    public string clothing = "Battle Armor";
    public string bodyType = "Large, Hunched, Muscular";
    public bool filteredBreathing = true;
    public int horns = 3;
    public int startingPopulation = 1000000;

    private RoverShip _rovership;

    public RoverShip rovership
    {
      get
      {
        return _rovership;
      }
      set
      {
        _rovership = value;
      }
    }

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
