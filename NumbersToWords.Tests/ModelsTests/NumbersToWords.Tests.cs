using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
  
namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumbersToWordsTests
  {
    [TestMethod]
    public void NumberToConvertConstructor_CreatesInstanceOfNumberToConvert_NumberToConvert()
    {
      NumberToConvert newNumberToConvert = new NumberToConvert();
      Assert.AreEqual(typeof(NumberToConvert), newNumberToConvert.GetType());
    }
  }
}