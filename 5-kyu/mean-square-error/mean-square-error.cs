public class Kata
{
  public static double Solution(int[] firstArray, int[] secondArray)
  {
    double total = 0;
    
    for (int i = 0; i < firstArray.Length; i++)
    {
      int difference = firstArray[i] - secondArray[i];
      total += difference * difference;
    }
​
    return total/firstArray.Length;
  }
}