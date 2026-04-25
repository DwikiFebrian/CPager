class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
            return new[]  { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
            return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
            birdsPerDay[^1] += 1;
    }

   public bool HasDayWithoutBirds()
{
    foreach (int birds in birdsPerDay)
    {
        if (birds == 0)
        {
            return true;
        }
    }

    return false;
}

    public int CountForFirstDays(int numberOfDays)
    {
        int howManyBirds = 0;
        for (int day = 0; day < numberOfDays; day += 1){
               howManyBirds += birdsPerDay[day];
           }
        return howManyBirds;
    }

    public int BusyDays()
    {
        int dayBusy = 0;
        foreach (int birds in birdsPerDay)
        {
            if (birds >= 5) {
                dayBusy += 1;
            }
        }

        return dayBusy;
    }
}
