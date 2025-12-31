namespace SunamoCssGenerator;

public class CssGenerator
{
    private readonly StringBuilder stringBuilder = new();

    public override string ToString()
    {
        return stringBuilder.ToString();
    }

    public void AddMediaMinMaxWidth(int tabCount, int maxWidth, Func<int, int> getMinFromMax)
    {
        AddTab(tabCount);
        stringBuilder.AppendLine("@media screen and (min-width: " + getMinFromMax(maxWidth) + "px) and (max-width: " + maxWidth +
                      "px) {");
    }


    public void AddId(int tabCount, string name, params CssProperty[] cssProps)
    {
        Add(tabCount, "#", name, cssProps);
    }

    public void AddClass(int tabCount, string name, params CssProperty[] cssProps)
    {
        Add(tabCount, ".", name, cssProps);
    }

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

        //stringBuilder.TrimEnd();
        End(tabCount);
    }

    public void End(int tabCount)
    {
        stringBuilder.AppendLine();
        AddTab(tabCount);
        stringBuilder.AppendLine("}");
        stringBuilder.AppendLine();
    }
}