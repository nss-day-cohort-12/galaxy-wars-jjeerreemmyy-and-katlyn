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
      string newFighter = "";
      string newFighterRace = "";

      Console.WriteLine("Enter your name, warrior.\n");
      newFighter = Console.ReadLine();

      Console.WriteLine("What race are you? Aldor, MurkBlood, or Sha'Tar?");
      newFighterRace = Console.ReadLine();

      MurkBlood murky = new MurkBlood();
      murky.name = "Murky";
      murky.planetName = "Krypton";
      RoverShip rovership = new RoverShip();
      rovership.pilots = new List<Draenei>();
      rovership.pilots.Add(murky);

      Aldor aldy = new Aldor();
      aldy.name = "Aldy";
      aldy.planetName = "Krypton";
      Battleship battleship = new Battleship();
      battleship.pilots = new List<Draenei>();
      battleship.pilots.Add(aldy);

      ShaTar shatty = new ShaTar();
      shatty.name = "Shatty";
      shatty.planetName = "Krypton";
      Spaceship spaceship = new Spaceship();
      spaceship.pilots = new List<Draenei>();
      spaceship.pilots.Add(shatty);

      if (newFighterRace == "MurkBlood")
      {
        murky.name = newFighter;
        Console.WriteLine(murky.Desc());
        Console.WriteLine("Good luck to your kind.\n");
      } else if (newFighterRace == "Aldor")
      {
        aldy.name = newFighter;
        Console.WriteLine(aldy.Desc());
        Console.WriteLine("Good luck to your kind.\n");
      } else if (newFighterRace == "Shatar")
      {
        shatty.name = newFighter;
        Console.WriteLine(shatty.Desc());
        Console.WriteLine("Good luck to your kind.\n");
      };

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
        Console.WriteLine("{0} is awesome! " + murky.name + " has attacked at {0}!\n", rovership.Move());

        double shatWeightedBonus = currShatPop * .02;
        double shatReligiousBonus = currShatPop * .01;
        currShatPop = currShatPop - 20000;
        currShatPop = currShatPop + 5000;
        currShatPop = currShatPop - 10000;
        currShatPop = currShatPop - shatReligiousBonus;
        Console.WriteLine("{0} is awesome! " + shatty.name + " has attacked at {0}!\n", spaceship.Move());

        double aldyWeightedBonus = currAldyPop * .02;
        currAldyPop = currAldyPop - 20000;
        currAldyPop = currAldyPop - 10000;
        currAldyPop = currAldyPop + murkReligiousBonus;
        currAldyPop = currAldyPop + shatReligiousBonus;
        Console.WriteLine("{0} is awesome! " + aldy.name + " has attacked at {0}!\n", battleship.Move());

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
          int anomoly = rnd.Next(1, 4);
          switch (anomoly)
          {
            case 1:
              relBeatsWarfare = false;
              warBeatsReligion = true;
              Console.WriteLine("The wars of " + murky.planetName + " have now raged for " + y + " years,\n and, after losing " + currMurkPop.ToString("#") + " of their people,\n a celestial anomoly has occured in favor of the MurkBlood!\n");
              break;
            case 2:
              warBeatsScience = false;
              sciBeatsWarfare = true;
              Console.WriteLine("The wars of " + shatty.planetName + " have now raged for " + y + " years,\n and, after losing " + currShatPop.ToString("#") + " of their people,\n a celestial anomoly has occured in favor of the Sha'Tar!\n");
              break;
            case 3:
              sciBeatsReligion = false;
              relBeatsScience = true;
              Console.WriteLine("The wars of " + aldy.planetName + " have now raged for " + y + " years,\n and, after losing " + currAldyPop.ToString("#") + " of their people,\n a celestial anomoly has occured in favor of the Aldor!\n");
              break;
          }
        }

        y++;

        if (currMurkPop <= 0)
        {
          Console.WriteLine("Sadly, after " + y + " years of war.\n " + murky.name + "'s kingdom and the race of MurkBlood are now EXTINCT.\n");
          if (currAldyPop > currShatPop)
          {
            Console.WriteLine(aldy.name + " ,and the race of Aldor now rule the planet of " + aldy.planetName + ".");
          } else
          {
            Console.WriteLine(shatty.name + " ,and the race of Sha'Tar now rule the planet of " + shatty.planetName + ".");
          };
          break;
        } else if (currShatPop <= 0)
        {
          Console.WriteLine("Sadly, after " + y + " years of war.\n " + shatty.name + "'s kingdom and the race of Sha'Tar are now EXTINCT.\n");
          if (currAldyPop > currMurkPop)
          {
            Console.WriteLine(aldy.name + " ,and the race of Aldor now rule the planet of " + aldy.planetName + ".");
          }
          else
          {
            Console.WriteLine(murky.name + " ,and the race of MurkBloods now rule the planet of " + murky.planetName + ".");
          };
          break;
        } else if (currAldyPop <= 0)
        {
          Console.WriteLine("Sadly, after " + y + " years of war.\n " + aldy.name + "'s kingdom and the race of Aldor are now EXTINCT.\n");
          if (currMurkPop > currShatPop)
          {
            Console.WriteLine(murky.name + " ,and the race of MurkBloods now rule the planet of " + murky.planetName + ".");
          }
          else
          {
            Console.WriteLine(shatty.name + " ,and the race of Sha'Tar now rule the planet of " + shatty.planetName + ".");
          };
          break;
        }

        Console.WriteLine("This year, the ongoing war has left only " + currAldyPop.ToString("#") + " people of Aldor alive,\n " + currMurkPop.ToString("#") + " people of the MurkBlood tribe,\n and " + currShatPop.ToString("#") + " people left in the tribe of Sha'Tar.\n");

      }

        
      Console.ReadLine();
    }
  }
}
