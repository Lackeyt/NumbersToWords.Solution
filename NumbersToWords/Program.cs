using System;
using NumbersToWords.Models;

namespace NumbersToWords
{
  public class NumbersToWordsProgram
  {
    public static void Main()
    {
      Console.WriteLine("Input number to convert");
      long input = long.Parse(Console.ReadLine());
      NumberToConvert numObj = new NumberToConvert(input);
      numObj.ConvertNumber();
      Console.WriteLine(numObj.StringNumber);
    }
  }
}