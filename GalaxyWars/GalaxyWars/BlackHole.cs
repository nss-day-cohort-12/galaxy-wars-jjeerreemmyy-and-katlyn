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

      ShaTar shatty = new ShaTar();
      shatty.name = "Shatty";
      Spaceship spaceship = new Spaceship();
      spaceship.pilots = new List<Draenei>();
      spaceship.pilots.Add(shatty);
      shatty.planetName = "Krypton";

      int y = 1;
      bool sciBeatsReligion = true;
      bool relBeatsWarfare = true;
      bool warBeatsScience = true;
      bool relBeatsScience = false;
      bool warBeatsReligion = false;
      bool sciBeatsWarfare = false;

      double currMurkPop = murky.startingPopulation;
      double currAldyPop = aldy.Population;
      double currShatPop = shatty.startingPopualtion;
      while (currMurkPop >= 0 || currShatPop >= 0 || currAldyPop >= 0)
      {
        double murkWeightedBonus = currMurkPop * .02;
        double murkReligiousBonus = currMurkPop * .01;
        currMurkPop = currMurkPop - 20000;
        currMurkPop = currMurkPop - 2500;
        currMurkPop = currMurkPop - murkReligiousBonus;
        
        double shatWeightedBonus = currShatPop * .02;
        double shatReligiousBonus = currShatPop * .01;
        currShatPop = currShatPop - 20000;
        currShatPop = currShatPop + 5000;
        currShatPop = currShatPop - 10000;
        currShatPop = currShatPop - shatReligiousBonus;

        double aldyWeightedBonus = currAldyPop * .02;
        currAldyPop = currAldyPop - 20000;
        currAldyPop = currAldyPop - 10000;
        currAldyPop = currAldyPop + murkReligiousBonus;
        currAldyPop = currAldyPop + shatReligiousBonus;
        
        if (relBeatsWarfare)
        {
          currMurkPop = currMurkPop - murkWeightedBonus;
        }
        else if (warBeatsReligion)
        {
          currAldyPop = currAldyPop - aldyWeightedBonus;
        }

        if (warBeatsScience)
        {
          currShatPop = currShatPop - shatWeightedBonus;
        } else if (sciBeatsWarfare)
        {
          currMurkPop = currMurkPop - murkWeightedBonus;
        }

        if (sciBeatsReligion)
        {
          currAldyPop = currAldyPop - aldyWeightedBonus;
        } else if (relBeatsScience)
        {
          currShatPop = currShatPop - shatWeightedBonus;
        }

        if (y % 25 == 0)
        {
          Random rnd = new Random();
          int anomoly = rnd.Next(1, 3);
          switch (anomoly)
          {
            case 1:
              relBeatsWarfare = false;
              warBeatsReligion = true;
              Console.WriteLine("The wars of " + murky.planetName + " have now raged for " + y + " years, and, after losing " + currMurkPop.ToString("#") + " of their people, a celestial anomoly has occured in favor of the MurkBlood!");
              break;
            case 2:
              warBeatsScience = false;
              sciBeatsWarfare = true;
              Console.WriteLine("The wars of " + shatty.planetName + " have now raged for " + y + " years, and, after losing " + currShatPop.ToString("#") + " of their people, a celestial anomoly has occured in favor of the Sha'Tar!");
              break;
            case 3:
              sciBeatsReligion = false;
              relBeatsScience = true;
              Console.WriteLine("The wars of " + aldy.planetName + " have now raged for " + y + " years, and, after losing " + currAldyPop.ToString("#") + " of their people, a celestial anomoly has occured in favor of the Aldor!");
              break;
          }
        }

        y++;

        if (currMurkPop <= 0)
        {
          Console.WriteLine("Sadly, after " + y + " years of war. " + murky.name + "'s kingdom and the race of MurkBlood are now EXTINCT.");
          break;
        } else if (currShatPop <= 0)
        {
          Console.WriteLine("Sadly, after " + y + " years of war. " + shatty.name + "'s kingdom and the race of Sha'Tar are now EXTINCT.");
          break;
        } else if (currAldyPop <= 0)
        {
          Console.WriteLine("Sadly, after " + y + " years of war. " + aldy.name + "'s kingdom and the race of Aldor are now EXTINCT.");
          break;
        }

        Console.WriteLine("The current population of Aldor is " + currAldyPop.ToString("#") + ".");
        Console.WriteLine("The current population of MurkBlood is " + currMurkPop.ToString("#") + ".");
        Console.WriteLine("The current population of ShaTar is " + currShatPop.ToString("#") + ".");
        Console.WriteLine("{0} is awesome" , spaceship.Move());
      }

        
      Console.ReadLine();
    }
  }
}
