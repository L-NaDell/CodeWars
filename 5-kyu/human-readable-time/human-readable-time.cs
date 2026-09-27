public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
      int hour = GetHour(seconds);
      int min = GetMin(seconds - (hour * 3600));
      int sec = (seconds - ((min * 60) + (hour * 3600)));
      
        return $"{hour.ToString("D2")}:{min.ToString("D2")}:{sec.ToString("D2")}";
    }
                 
    private static int GetHour(int seconds)
    {
      return seconds / 3600;
    }
                 
    private static int GetMin(int seconds)
    {
      return seconds / 60;
    } 
  
}