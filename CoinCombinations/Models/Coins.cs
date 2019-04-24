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
      Quarters = money;
      Dimes = 100;
      Nickels = 100;
      Pennies = 100;
    }

    public int GetQuarters()
    {
      return Quarters;
    }

  }
}
