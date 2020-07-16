using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class NumberToConvert
  {
    private Dictionary<int, string> _digitStringifier = new Dictionary<int, string>() { {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}};
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
      return _digitStringifier[input];
    }
  }
}