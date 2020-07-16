namespace NumbersToWords.Models
{
  public class NumberToConvert
  {
    public int Input { get; set; }
    public string StringNumber { get; set;}
    public NumberToConvert(int input)
    {
      Input = input;
      StringNumber = "";
    }
    public string ConvertNumber()
    {
      return StringNumber;
    }
  }
}