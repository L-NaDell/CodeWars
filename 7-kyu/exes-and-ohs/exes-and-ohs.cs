using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    int exes = 0;
    int ohhs = 0;
    
    foreach (char i in input)
    {
      if (i == 'x' || i == 'X')
        exes++;
      else if (i == 'o' || i == 'O')
        ohhs++;
    }
    return (exes == ohhs);
  }
}