namespace SunamoCssGenerator;

public class CssProps
{
    /// <summary>
    /// Creates a CSS width property
    /// </summary>
    /// <param name="value">The width value (e.g., "100px", "50%")</param>
    /// <returns>A CssProperty representing the width property</returns>
    public static CssProperty Width(string value) => new CssProperty(Properties.Width, value);
}