// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoCssGenerator;

public class CssProps
{
    public static CssProperty Width(string v)
    {
        return new CssProperty(Properties.Width, v);
    }
}