using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombinations.Models;
using System;
using System.Collections.Generic;


namespace CoinCombinations.Tests
{
  [TestClass]
  public class ChangeMakeTest
  {

    [TestMethod]
    public void CheckQuarters_CheckForQuarters_NumberOfQuarters()
    {
      //Arrange
      ChangeMake change = new ChangeMake(25);
      //Act

      //Arrange
      Assert.AreEqual(1, change.GetQuarters());
    }

    [TestMethod]
    public void CheckDimes_CheckForDimes_NumberOfDimes()
    {
      //Arrange
      ChangeMake change = new ChangeMake(10);
      //Act

      //Arrange
      Assert.AreEqual(1, change.GetDimes());
    }

    [TestMethod]
    public void CheckNickels_CheckForNickels_NumberOfNickels()
    {
      //Arrange
      ChangeMake change = new ChangeMake(5);
      //Act

      //Arrange
      Assert.AreEqual(1, change.GetNickels());
    }

    [TestMethod]
    public void CheckPennies_CheckForPennies_NumberOfPennies()
    {
      //Arrange
      ChangeMake change = new ChangeMake(1);
      //Act

      //Arrange
      Assert.AreEqual(1, change.GetPennies());
    }

    [TestMethod]
    public void GiveChange_Coins_NumberOfEach()
    {
      //Arrange
      ChangeMake change = new ChangeMake(41);
      //Act

      //Arrange
      Assert.AreEqual("Quarters: 1, Dimes: 1, Nickels: 1, Pennies: 1", change.GiveChange());
    }

  }
}
