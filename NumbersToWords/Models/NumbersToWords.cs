using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class NumberToConvert
  {
    private Dictionary<int, string> _digitStringifier = new Dictionary<int, string>() { {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}};
    private Dictionary<int, string> _teenDigitStringifier = new Dictionary<int, string>() { {10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"}};
    public int Input { get; set; }
    public string StringNumber { get; set;}
    public NumberToConvert(int input)
    {
      Input = input;
      StringNumber = "";
    }
    public string ConvertNumber()
    {
      string digitString = ConvertDigits(Input);
      StringNumber = digitString + StringNumber;
      return StringNumber;
    }

    private string ConvertDigits(int input)
    {
      if (input < 10) 
      {
        return _digitStringifier[input];
      }
      else if (input < 20)
      {
        return _teenDigitStringifier[input];
      }
      else
      {
        return "not available yet";
      }
    }
  }
}