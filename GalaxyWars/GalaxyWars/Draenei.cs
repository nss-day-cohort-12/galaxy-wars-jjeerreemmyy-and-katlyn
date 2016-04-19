using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
  class Draenei
  {
        public virtual string Desc() { return "hooved aliens"; } 
        private string _name = "";
        private string _planetName = "";
        public bool hasHooves = true;
        public string starType = "BlackHole";

        public string name
        {
            get
            {
             return _name;
             }
            set
             {
             if (value != "")
                {
                 _name = value;
            }

      }
    }

    public string planetName
    {
      get
      {
        return _planetName;
      }
      set
      {
        if (value != "")
        {
          _planetName = value;
        }

       }
      }
    }
  }
