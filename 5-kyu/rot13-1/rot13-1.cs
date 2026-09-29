using System;
using System.Collections.Generic;
​
public class Kata
{
  public static string Rot13(string message)
  {
    char[] alpha = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
    List<char> list = new List<char>();
    
    foreach (char letter in message)
    {
      char lower = char.ToLower(letter);
      int position = Array.IndexOf(alpha, lower);
        
      if (position == -1)
      {
        list.Add(letter);
      }
      else if (letter == lower)
      {
        list.Add(alpha[(position + 13) % 26]);  
      }
      else
      {
        char upper = char.ToUpper(alpha[(position + 13) % 26]);
        list.Add(upper);  
      }
      
    }
    return string.Join( "", list);
  }
}