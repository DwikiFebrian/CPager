using System.Linq;

public class HighScores
{
    private List<int> list;
        
    public HighScores(List<int> list)
    {
        this.list = list;
    }

    public List<int> Scores()
    {
        return list;
    }

    public int Latest()
    {
        return list[^1];
    }

    public int PersonalBest()
    {
        return list.Max();
    }

    public List<int> PersonalTopThree()
    {
       return list.OrderByDescending(n => n).Take(3).ToList();
    }
}