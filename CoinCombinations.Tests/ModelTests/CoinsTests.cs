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

  }
}
