using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
  interface IWarfare
  {
    //Defines the properties of a warmongering species.
    bool violent();

    string weaponSpecialty();

    bool undergroundBarracks();
  }
}
