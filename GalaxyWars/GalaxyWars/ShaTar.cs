using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
  class ShaTar : Draenei, ISpace
  {
    public string description = "The Sha'tar, or 'born of light,' are Draenei that aided the creation of the New Space Order.";
    public string skin = "Blue";
    public string clothing = "Advanced Space Suite";
    public string bodyType = "Short, Weak, Skinny";
    public bool bigLungs = true;
    public int horns = 2;
    public int startingPopualtion = 1000000;

    public bool advancedSpaceStation()
    {
      return true;
    }

    public bool evasion()
    {
      return true;
    }

    public string highTech()
    {
      return "Advanced Communication";
    }
  }
}

