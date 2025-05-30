namespace SunamoCssGenerator;

public class CssGenerator
{
    private readonly StringBuilder sb = new();

    public override string ToString()
    {
        return sb.ToString();
    }

    public void AddMediaMinMaxWidth(int tabCount, int maxWidth, Func<int, int> GetMinFromMax)
    {
        AddTab(tabCount);
        sb.AppendLine("@media screen and (min-width: " + GetMinFromMax(maxWidth) + "px) and (max-width: " + maxWidth +
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
        for (var i = 0; i < tabCount; i++) sb.Append("\t");
    }

    private void Add(int tabCount, string v, string name, CssProperty[] cssProps)
    {
        AddTab(tabCount);
        sb.AppendLine(v + name + " {");
        foreach (var item in cssProps)
        {
            AddTab(tabCount + 1);
            sb.AppendLine(PropertiesConversions.Convert(item.Property.ToString()) + ": " + item.Value + ";");
        }

        //sb.TrimEnd();
        End(tabCount);
    }

    public void End(int tabCount)
    {
        sb.AppendLine();
        AddTab(tabCount);
        sb.AppendLine("}");
        sb.AppendLine();
    }
}