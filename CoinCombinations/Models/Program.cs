using System;
using System.Collections.Generic;

namespace CoinCombinations.Models
{
  public class Program
  {

    public static void Main()
    {

      Console.WriteLine("How much do I owe you?");
      int stringUserInput = int.Parse(Console.ReadLine());
      ChangeMake newChangeMake = new ChangeMake(stringUserInput);
      Console.WriteLine(newChangeMake.GiveChange());

    }
  }
}
