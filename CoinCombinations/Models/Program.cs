using System;
using System.Collections.Generic;

namespace CoinCombinations.Models
{
  public class Program
  {

    public static void Main()
    {

      Console.WriteLine("How many cents do you have?");
      int stringUserInput = int.Parse(Console.ReadLine());
      ChangeMake newChangeMake = new ChangeMake(stringUserInput);
      Console.WriteLine(newChangeMake.GiveChange());

    }
  }
}
