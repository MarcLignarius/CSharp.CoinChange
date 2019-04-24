using System;
using System.Collections.Generic;

namespace CoinCombinations.Models
{
  public class ChangeMake
  {
    private int Quarters;
    private int Dimes;
    private int Nickels;
    private int Pennies;

    public ChangeMake(int money)
    {
      Quarters = 0;
      Dimes = 0;
      Nickels = 0;
      Pennies = 0;
      while(money >= 25)
      {
        money -= 25;
        Quarters++;
      }
      while(money >=10)
      {
        money -= 10;
        Dimes++;
      }
    }

    public int GetQuarters()
    {
      return Quarters;
    }

    public int GetDimes()
    {
      return Dimes;
    }

    public int GetNickels()
    {
      return Nickels;
    }

  }
}

// while(money >=5)
// {
//   money -= 5;
//   Nickels++;
// }
// while(money >=1)
// {
//   money -= 1;
//   Pennies++;
// }

// public int GetPennies()
// {
//   return Pennies;
// }
