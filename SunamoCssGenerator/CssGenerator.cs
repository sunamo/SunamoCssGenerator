namespace SunamoCssGenerator;

/// <summary>
/// Represents the css generator type.
/// </summary>
public class CssGenerator
{
    private readonly StringBuilder stringBuilder = new();

    /// <summary>
    /// Returns the generated CSS as a string
    /// </summary>
    /// <returns>The generated CSS code</returns>
    public override string ToString() => stringBuilder.ToString();

    /// <summary>
    /// Add media min max width.
    /// </summary>
    /// <param name="tabCount">The tab count.</param>
    /// <param name="maxWidth">The max width.</param>
    /// <param name="getMinFromMax">The get min from max.</param>
    public void AddMediaMinMaxWidth(int tabCount, int maxWidth, Func<int, int> getMinFromMax)
    {
        AddTab(tabCount);
        stringBuilder.AppendLine("@media screen and (min-width: " + getMinFromMax(maxWidth) + "px) and (max-width: " + maxWidth +
                      "px) {");
    }

    /// <summary>
    /// Add id.
    /// </summary>
    /// <param name="tabCount">The tab count.</param>
    /// <param name="name">The name.</param>
    /// <param name="cssProps">The css props.</param>
    public void AddId(int tabCount, string name, params CssProperty[] cssProps)
    {
        Add(tabCount, "#", name, cssProps);
    }

    /// <summary>
    /// Add class.
    /// </summary>
    /// <param name="tabCount">The tab count.</param>
    /// <param name="name">The name.</param>
    /// <param name="cssProps">The css props.</param>
    public void AddClass(int tabCount, string name, params CssProperty[] cssProps)
    {
        Add(tabCount, ".", name, cssProps);
    }

    /// <summary>
    /// Add tab.
    /// </summary>
    /// <param name="tabCount">The tab count.</param>
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
    /// End.
    /// </summary>
    /// <param name="tabCount">The tab count.</param>
    public void End(int tabCount)
    {
        stringBuilder.AppendLine();
        AddTab(tabCount);
        stringBuilder.AppendLine("}");
        stringBuilder.AppendLine();
    }
}
