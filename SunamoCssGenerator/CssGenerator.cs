namespace SunamoCssGenerator;

/// <summary>
/// Generates CSS code with proper indentation and formatting
/// </summary>
public class CssGenerator
{
    private readonly StringBuilder stringBuilder = new();

    /// <summary>
    /// Returns the generated CSS as a string
    /// </summary>
    /// <returns>The generated CSS code</returns>
    public override string ToString()
    {
        return stringBuilder.ToString();
    }

    /// <summary>
    /// Adds a media query with min-width and max-width screen constraints
    /// </summary>
    /// <param name="tabCount">Number of tabs for indentation</param>
    /// <param name="maxWidth">Maximum width in pixels</param>
    /// <param name="getMinFromMax">Function to calculate minimum width from maximum width</param>
    public void AddMediaMinMaxWidth(int tabCount, int maxWidth, Func<int, int> getMinFromMax)
    {
        AddTab(tabCount);
        stringBuilder.AppendLine("@media screen and (min-width: " + getMinFromMax(maxWidth) + "px) and (max-width: " + maxWidth +
                      "px) {");
    }

    /// <summary>
    /// Adds a CSS ID selector with properties
    /// </summary>
    /// <param name="tabCount">Number of tabs for indentation</param>
    /// <param name="name">ID name without the # prefix</param>
    /// <param name="cssProps">CSS properties to apply</param>
    public void AddId(int tabCount, string name, params CssProperty[] cssProps)
    {
        Add(tabCount, "#", name, cssProps);
    }

    /// <summary>
    /// Adds a CSS class selector with properties
    /// </summary>
    /// <param name="tabCount">Number of tabs for indentation</param>
    /// <param name="name">Class name without the . prefix</param>
    /// <param name="cssProps">CSS properties to apply</param>
    public void AddClass(int tabCount, string name, params CssProperty[] cssProps)
    {
        Add(tabCount, ".", name, cssProps);
    }

    /// <summary>
    /// Adds tabs for indentation
    /// </summary>
    /// <param name="tabCount">Number of tabs to add</param>
    public void AddTab(int tabCount)
    {
        for (var i = 0; i < tabCount; i++) stringBuilder.Append("\t");
    }

    private void Add(int tabCount, string prefix, string name, CssProperty[] cssProps)
    {
        AddTab(tabCount);
        stringBuilder.AppendLine(prefix + name + " {");
        foreach (var item in cssProps)
        {
            AddTab(tabCount + 1);
            stringBuilder.AppendLine(PropertiesConversions.Convert(item.Property.ToString()) + ": " + item.Value + ";");
        }

        End(tabCount);
    }

    /// <summary>
    /// Adds a closing brace with proper indentation
    /// </summary>
    /// <param name="tabCount">Number of tabs for indentation</param>
    public void End(int tabCount)
    {
        stringBuilder.AppendLine();
        AddTab(tabCount);
        stringBuilder.AppendLine("}");
        stringBuilder.AppendLine();
    }
}