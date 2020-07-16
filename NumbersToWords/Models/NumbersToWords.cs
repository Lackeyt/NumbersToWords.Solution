using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class NumberToConvert
  {
    private Dictionary<int, string> _digitStringifier = new Dictionary<int, string>() { {0, ""}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}};
    private Dictionary<int, string> _teenDigitStringifier = new Dictionary<int, string>() { {10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"}};
    private Dictionary<int, string> _tensPlaceStringifier = new Dictionary<int, string>() { {20, "twenty"}, {30, "thirty"}, {40, "forty"}, {50, "fifty"}, {60, "sixty"}, {70, "seventy"}, {80, "eighty"}, {90, "ninety"}};
    public int Input { get; set; }
    public string StringNumber { get; set;}
    public NumberToConvert(int input)
    {
      Input = input;
    }
    public void ConvertNumber()
    {
      StringNumber = (ConvertDigits(Input)).Trim();
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
      else if (input < 100)
      {
        int onePlace = input % 10;
        int tensPlace = input - onePlace;
        return (_tensPlaceStringifier[tensPlace] + " " + _digitStringifier[onePlace]);
      }
      else if (input < 1000)
      {
        int hundredsPlace = (input - (input % 100)) / 100;
        return (_digitStringifier[hundredsPlace] + " hundred " + ConvertDigits(input % 100));
      }
      else if (input < 1000000)
      {
        int thousandsPlace = (input - (input % 1000)) / 1000;
        return (ConvertDigits(thousandsPlace) + " thousand " + ConvertDigits(input % 1000));
      }
      else
      {
        return "not available yet";
      }
    }
  }
}