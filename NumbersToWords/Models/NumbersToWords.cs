using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class NumberToConvert
  {
    private Dictionary<long, string> _digitStringifier = new Dictionary<long, string>() { {0, ""}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}};
    private Dictionary<long, string> _teenDigitStringifier = new Dictionary<long, string>() { {10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"}};
    private Dictionary<long, string> _tensPlaceStringifier = new Dictionary<long, string>() { {20, "twenty"}, {30, "thirty"}, {40, "forty"}, {50, "fifty"}, {60, "sixty"}, {70, "seventy"}, {80, "eighty"}, {90, "ninety"}};
    public long Input { get; set; }
    public string StringNumber { get; set;}
    public NumberToConvert(long input)
    {
      Input = input;
    }
    public void ConvertNumber()
    {
      StringNumber = (ConvertDigits(Input)).Trim();
    }

    private string ConvertDigits(long input)
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
        long onePlace = input % 10;
        long tensPlace = input - onePlace;
        return (_tensPlaceStringifier[tensPlace] + " " + _digitStringifier[onePlace]);
      }
      else if (input < 1000)
      {
        long hundredsPlace = (input - (input % 100)) / 100;
        return (_digitStringifier[hundredsPlace] + " hundred " + ConvertDigits(input % 100));
      }
      else if (input < 1000000)
      {
        long thousandsPlace = (input - (input % 1000)) / 1000;
        return (ConvertDigits(thousandsPlace) + " thousand " + ConvertDigits(input % 1000));
      }
      else if (input < 1000000000)
      {
        long millionsPlace = (input - (input % 1000000)) / 1000000;
        return (ConvertDigits(millionsPlace) + " million " + ConvertDigits(input % 1000000));
      }
      else if (input < 1000000000000)
      {
        long billionsPlace = (input - (input % 1000000000)) / 1000000000;
        return (ConvertDigits(billionsPlace) + " billion " + ConvertDigits(input % 1000000000));
      }
      else
      {
        return "One Trillion+";
      }
    }
  }
}