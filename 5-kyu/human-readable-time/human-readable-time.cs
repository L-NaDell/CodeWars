public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
      int sec = seconds % 60;
      int totalMin = seconds / 60;
      int min = totalMin % 60;
      int hour = totalMin / 60;
      
      return $"{hour.ToString("D2")}:{min.ToString("D2")}:{sec.ToString("D2")}";
    }
}