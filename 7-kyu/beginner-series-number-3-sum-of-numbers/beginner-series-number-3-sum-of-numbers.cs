  using System;
  public class Sum
  {
     public int GetSum(int a, int b)
     {
       int sum = 0;
       int lowerNumb = (a < b) ? a : b;
       int higherNumb = (a > b) ? a : b;
       
       if (a == b)
       {
         return a;
       }
       
       for (int i = lowerNumb; i <= higherNumb; i++)
       {
         sum += i;
       }
       
       return sum;
     }
  }