  using System.Text;
​
  public class Kata
  {
      public static string DuplicateEncode(string word)
      {
          StringBuilder builder = new StringBuilder();
          string lower = word.ToLower();
​
          foreach (char character in lower)
          {
              if (CountOccurrences(lower, character) > 1)
              {
                  builder.Append(')');
              }
              else
              {
                  builder.Append('(');
              }
          }
​
          return builder.ToString();
      }
​
      private static int CountOccurrences(string source, char target)
      {
          int count = 0;
          foreach (char c in source)
          {
              if (c == target)
              {
                  count++;
              }
          }
          return count;
      }
  }