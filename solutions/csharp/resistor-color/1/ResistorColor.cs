public static class ResistorColor
{
    static string[] colors = {
        "black", "brown", "red", "orange",
        "yellow", "green", "blue",
        "violet", "grey", "white"
    };
    
    public static int ColorCode(string color)
    {
        return Array.IndexOf(colors, color);
    }

    public static string[] Colors()
    {
        return colors;
    }
}