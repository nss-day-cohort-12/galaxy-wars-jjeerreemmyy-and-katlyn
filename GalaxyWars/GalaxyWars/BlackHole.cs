using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GalaxyWars
{
  class BlackHole
  {
    static void Main(string[] args)
    {
      MurkBlood murky = new MurkBlood();
      murky.name = "Murky";
      murky.planetName = "Krypton";

      Aldor aldy = new Aldor();
      aldy.name = "Aldy";
      aldy.planetName = "Krypton";

      int y = 1;
      double currMurkPop = murky.startingPopulation;
      double currAldyPop = aldy.Population;
      while (y < 25)
      {
        double religiousBonus = currMurkPop * .01;
        currMurkPop = currMurkPop - 20000;
        currMurkPop = currMurkPop - 2500;
        currMurkPop = currMurkPop - religiousBonus;

        currAldyPop = currAldyPop - 20000;
        currAldyPop = currAldyPop - 10000;
        currAldyPop = currAldyPop + religiousBonus;

        

        y++;
        Console.WriteLine("The current population of Aldor is " + currAldyPop.ToString("#") + ".");
        Console.WriteLine("The current population of MurkBlood is " + currMurkPop.ToString("#") + ".");
      }


      Console.WriteLine(murky.name + " is from " + murky.planetName + " and his people have been reduced to a population of " + currMurkPop.ToString("#"));
      Console.ReadLine();
    }
  }
}
