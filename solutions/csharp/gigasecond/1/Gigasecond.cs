public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        DateTime nextDate = moment.AddSeconds(1000000000);
        return nextDate;
    }
}