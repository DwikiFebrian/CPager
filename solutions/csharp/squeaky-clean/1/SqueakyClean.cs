using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var result = new StringBuilder();
        bool makeUpper = false;
        
        bool IsGreekLetter(char c)
        {
        return c >= '\u03B1' && c <= '\u03C9';
        }
        
        foreach (char c in identifier)
        {
            if (c == ' ')
            {
                result.Append('_');
                continue;
            }

            if (char.IsControl(c))
            {
                result.Append("CTRL");
                continue;
            }

            if (c == '-')
            {
                makeUpper = true;
                continue;
            }
            
            if (!char.IsLetter(c) || IsGreekLetter(c))
            {
                continue;
            }

            if (makeUpper) 
            {
                result.Append(Char.ToUpper(c));
                makeUpper = false;
                continue;
            }
            else
            {
                result.Append(c);
                continue;
            }

        }

        return result.ToString();
    }
}
