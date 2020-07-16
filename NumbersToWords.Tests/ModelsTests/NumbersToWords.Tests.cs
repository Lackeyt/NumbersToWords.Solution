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
      NumberToConvert newNumberToConvert = new NumberToConvert(1);
      Assert.AreEqual(typeof(NumberToConvert), newNumberToConvert.GetType());
    }

    [TestMethod]
    public void ConvertNumber_ConvertsASingleDigit_One()
    {
      NumberToConvert newNumberToConvert = new NumberToConvert(1);
      newNumberToConvert.ConvertNumber();
      Assert.AreEqual("one", newNumberToConvert.StringNumber);
    }

    [TestMethod]
    public void ConvertNumber_ConvertsADoubleDigitFrom10to19_String()
    {
      NumberToConvert newNumberToConvert = new NumberToConvert(14);
      newNumberToConvert.ConvertNumber();
      Assert.AreEqual("fourteen", newNumberToConvert.StringNumber);
    }

    [TestMethod]
    public void ConvertNumber_ConvertsADoubleDigitFrom20To99_String()
    {
      NumberToConvert newNumberToConvert = new NumberToConvert(20);
      newNumberToConvert.ConvertNumber();
      Assert.AreEqual("twenty", newNumberToConvert.StringNumber);
    }

    [TestMethod]
    public void ConvertNumber_ConvertsADoubleDigitFrom100To999_String()
    {
      NumberToConvert newNumberToConvert = new NumberToConvert(367);
      newNumberToConvert.ConvertNumber();
      Assert.AreEqual("three hundred sixty seven", newNumberToConvert.StringNumber);
    }
  }
}