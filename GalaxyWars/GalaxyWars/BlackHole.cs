using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GalaxyWars
{
  //The primary class of BlackHole is the galaxy in which the galaxy wars will take place.
  class BlackHole
  {
    static void Main(string[] args)
    {
      string newFighter = "";
      string newFighterRace = "";

      //Accepts user input from console and assigns that value to newFighter variable.
      Console.WriteLine("Enter your name, warrior.\n");
      newFighter = Console.ReadLine();

      //Accepts user input from console and assigns that value to the newFighterRace variable.
      Console.WriteLine("What race are you? Aldor, MurkBlood, or Sha'Tar?");
      newFighterRace = Console.ReadLine();

      //Each new instance of species creates a "fighter" to reference in battle.
      //Murkblood represents the "warrior" population.
      MurkBlood murky = new MurkBlood();
      murky.name = "Murky";
      murky.planetName = "Krypton";
      //Define a new instance of vehicle type and add the species type as a pilot using override.
      RoverShip rovership = new RoverShip();
      rovership.pilots = new List<Draenei>();
      rovership.pilots.Add(murky);

      //Aldor represents the "religious" population.
      Aldor aldy = new Aldor();
      aldy.name = "Aldy";
      aldy.planetName = "Krypton";
      //Define a new instance of vehicle type and add the species type as a pilot using override.
      Battleship battleship = new Battleship();
      battleship.pilots = new List<Draenei>();
      battleship.pilots.Add(aldy);

      //ShaTar represents the "space faring" population.
      ShaTar shatty = new ShaTar();
      shatty.name = "Shatty";
      shatty.planetName = "Krypton";
      //Define a new instance of vehicle type and add the species type as a pilot using override.
      Spaceship spaceship = new Spaceship();
      spaceship.pilots = new List<Draenei>();
      spaceship.pilots.Add(shatty);

      //Accepts the values from the user input and assigns that user a name and race based on his/her choice.
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

      //Sets a counter for "years" to increase as each year passes.
      int y = 1;

      //Sets the initial values of how battles are weighted due to each species' favorable attributes.
      bool sciBeatsReligion = true;
      bool relBeatsWarfare = true;
      bool warBeatsScience = true;

      //Every 25 years, one of the cases below is switched to true causing the opposite recourse.
      bool relBeatsScience = false;
      bool warBeatsReligion = false;
      bool sciBeatsWarfare = false;

      //Define each species' starting population as a double variable, to be changed as the years pass.
      double currMurkPop = murky.startingPopulation;
      double currAldyPop = aldy.Population;
      double currShatPop = shatty.startingPopualtion;

      //While each species' population is still above 0, the wars will continue.
      while (currMurkPop >= 0 || currShatPop >= 0 || currAldyPop >= 0)
      {

        //Weighted bonuses allow for 2% of the current population to be affected in battle.
        double murkWeightedBonus = currMurkPop * .02;
        //Each species' religious calculation is subtracted from their population.
        double murkReligiousBonus = currMurkPop * .005;
        //Creates a random number between 10 and 15K to replicate general population loss in battle.
        Random rnd1 = new Random();
        int murkPopLoss = rnd1.Next(10000, 15000);
        //Warmongering species loses an additional 2500 people a year.
        currMurkPop = currMurkPop - murkPopLoss;
        currMurkPop = currMurkPop - 2500;
        currMurkPop = currMurkPop - murkReligiousBonus;
        Console.WriteLine("{0} is awesome! " + murky.name + " has attacked at {0}!\n", rovership.Move());

        //Weighted bonuses allow for 2% of the current population to be affected in battle.
        double shatWeightedBonus = currShatPop * .02;
        //Each species' religious calculation is subtracted from their population.
        double shatReligiousBonus = currShatPop * .005;
        //Creates a random number between 10 and 15K to replicate general population loss in battle.
        Random rnd2 = new Random();
        int shatPopLoss = rnd2.Next(10000, 15000);
        //The space faring species recovers 5000 people each year, and the warmongering species kills 10K more of their population.
        currShatPop = currShatPop - shatPopLoss;
        currShatPop = currShatPop + 5000;
        currShatPop = currShatPop - 10000;
        currShatPop = currShatPop - shatReligiousBonus;
        Console.WriteLine("{0} is awesome! " + shatty.name + " has attacked at {0}!\n", spaceship.Move());

        //Weighted bonuses allow for 2% of the current population to be affected in battle.
        double aldyWeightedBonus = currAldyPop * .02;
        Random rnd3 = new Random();
        int aldyPopLoss = rnd3.Next(10000, 15000);
        //The religious species loses 10K people to the warmongerers and gains the religious bonus population due to the converted people acquired from the other two species.
        currAldyPop = currAldyPop - aldyPopLoss;
        currAldyPop = currAldyPop - 10000;
        currAldyPop = currAldyPop + murkReligiousBonus;
        currAldyPop = currAldyPop + shatReligiousBonus;
        Console.WriteLine("{0} is awesome! " + aldy.name + " has attacked at {0}!\n", battleship.Move());

        //Check to see which species type outweighs the other in battle, and change the species favor after the 25 year anomoly.
        //Based on which species type outweighs the other, subtract the weighted bonus accordingly.
        if (relBeatsWarfare)
        {
          currMurkPop = currMurkPop - murkWeightedBonus;
        }
        else if (warBeatsReligion)
        {
          currAldyPop = currAldyPop - aldyWeightedBonus;
        };

        if (warBeatsScience)
        {
          currShatPop = currShatPop - shatWeightedBonus;
        } else if (sciBeatsWarfare)
        {
          currMurkPop = currMurkPop - murkWeightedBonus;
        };

        if (sciBeatsReligion)
        {
          currAldyPop = currAldyPop - aldyWeightedBonus;
        } else if (relBeatsScience)
        {
          currShatPop = currShatPop - shatWeightedBonus;
        };

        //Each 25 years, the "celestial anomoly" causes each weighted battle to have the opposite recourse.
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

        //The battle has ended. The year is over. Add a counter to the year.
        y++;

        //Check to see which population reaches zero first.
        //When a population reaches zero, end the wars, declare a winner, and declare an extinct species.
        if (currMurkPop <= 0)
        {
          Console.WriteLine("Sadly, after " + y + " years of war.\n " + murky.name + "'s kingdom and the race of MurkBlood are now EXTINCT.\n");
          if (currAldyPop > currShatPop)
          {
            Console.WriteLine(aldy.name + ", and the race of Aldor now rule the planet of " + aldy.planetName + ".");
          } else
          {
            Console.WriteLine(shatty.name + ", and the race of Sha'Tar now rule the planet of " + shatty.planetName + ".");
          };
          break;
        } else if (currShatPop <= 0)
        {
          Console.WriteLine("Sadly, after " + y + " years of war.\n " + shatty.name + "'s kingdom and the race of Sha'Tar are now EXTINCT.\n");
          if (currAldyPop > currMurkPop)
          {
            Console.WriteLine(aldy.name + ", and the race of Aldor now rule the planet of " + aldy.planetName + ".");
          }
          else
          {
            Console.WriteLine(murky.name + ", and the race of MurkBloods now rule the planet of " + murky.planetName + ".");
          };
          break;
        } else if (currAldyPop <= 0)
        {
          Console.WriteLine("Sadly, after " + y + " years of war.\n " + aldy.name + "'s kingdom and the race of Aldor are now EXTINCT.\n");
          if (currMurkPop > currShatPop)
          {
            Console.WriteLine(murky.name + ", and the race of MurkBloods now rule the planet of " + murky.planetName + ".");
          }
          else
          {
            Console.WriteLine(shatty.name + ", and the race of Sha'Tar now rule the planet of " + shatty.planetName + ".");
          };
          break;
        }

        //Alerts user to the outcome of the galaxy wars.
        Console.WriteLine("This year, the ongoing war has left only " + currAldyPop.ToString("#") + " people of Aldor alive,\n " + currMurkPop.ToString("#") + " people of the MurkBlood tribe,\n and " + currShatPop.ToString("#") + " people left in the tribe of Sha'Tar.\n");

      }

        
      Console.ReadLine();
    }
  }
}
