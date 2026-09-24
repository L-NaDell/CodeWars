public class Kata
{
    public static int Find(int[] integers)
    {
      return FindOutlier (integers, EvenOrOdd(integers));
    }
  
    private static int EvenOrOdd (int[] integers)
    {
      var firstNum = integers[0] % 2;
      var secondNum = integers[1] % 2;
      var thirdNum = integers[2] % 2;
      
      if ((firstNum == 0 && secondNum == 0) ||
          (secondNum == 0 && thirdNum == 0) ||
          (thirdNum == 0 && firstNum == 0))
        {return 1;}
      
      else
        return 0;
    }
  
    private static int FindOutlier (int[] integers, int EvenOrOdd)
    {
      int findNumber = -1;
      int arrayPosition = -1;
      
      do
      {
        arrayPosition = (arrayPosition + 1);
        findNumber = integers[arrayPosition] % 2;
        if (findNumber < 0)
        {
          findNumber = -findNumber;
        }
      }
      while (findNumber != EvenOrOdd);
      
      return integers[(arrayPosition)];
    }
  
}