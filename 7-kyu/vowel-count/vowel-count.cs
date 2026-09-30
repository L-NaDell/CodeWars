using System;
​
public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
​
        foreach (char letter in str)
        {
          if (letter.ToString() == "a" || 
              letter.ToString() == "e" ||
              letter.ToString() == "i" ||
              letter.ToString() == "o" ||
              letter.ToString() == "u")
          {
            vowelCount++;
          }
        }
​
        return vowelCount;
    }
}
​