namespace SunamoCssGenerator;

public class CssProps
{
    public static CssProperty Width(string value)
    {
        return new CssProperty(Properties.Width, value);
    }
}