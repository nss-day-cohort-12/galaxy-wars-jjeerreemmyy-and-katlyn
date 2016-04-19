using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
    class Aldor: Draenei, IReligion
    {
        public override string Desc()
            { return "This faction is made up of priests.\n"; } 
        public string Skin = "Red";
        public string clothing = "Robes";
        public string BodyType =  "tall, upright, lean, human like";
        public bool HasGills = true;
        public int Antennae = 6 ;

        public int Population = 1000000;
        public bool telepathy()
        {
            return true;
        }

        public bool hasTemple()
        {
            return true;
        }

        public bool persuasive()
        {
            return true;
        }

        public int SpecialPowers()
        {
            return 67;
        }
    }
}
