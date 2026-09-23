public class Number
{
  public static int DigitalRoot(long n)
  {
    int sum = 0;
    
    do
    {  
      foreach (char number in n.ToString())
      {
        sum += number - '0';
      }
      n = sum;
      sum = 0;
    }  
    while (n >= 10); 
    
    return (int)n;
    
  }
}