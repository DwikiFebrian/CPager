class Lasagna
{
    private const int ExpectedMinutes = 40;
    
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() {
        return ExpectedMinutes;
    }
    
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int remainTime){
        return ExpectedMinutes - remainTime;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int prepTime){
        return 2*prepTime;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int prepTime1, int prepTime2){
        return PreparationTimeInMinutes(prepTime1) + prepTime2;
    }
}
