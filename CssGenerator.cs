<<<<<<< HEAD


public class CssGenerator
{
    StringBuilder sb = new StringBuilder();
=======
namespace SunamoCssGenerator;

public class CssGenerator
{
    private readonly StringBuilder sb = new();
>>>>>>> 29d1e5be02b542c7c9284024ef8bdf374aca4aff

    public override string ToString()
    {
        return sb.ToString();
    }

    public void AddMediaMinMaxWidth(int tabCount, int maxWidth, Func<int, int> GetMinFromMax)
    {
        AddTab(tabCount);
<<<<<<< HEAD
        sb.AppendLine("@media screen and (min-width: "+ GetMinFromMax(maxWidth) +"px) and (max-width: " + maxWidth + "px) {");
    }

    
=======
        sb.AppendLine("@media screen and (min-width: " + GetMinFromMax(maxWidth) + "px) and (max-width: " + maxWidth +
                      "px) {");
    }

>>>>>>> 29d1e5be02b542c7c9284024ef8bdf374aca4aff

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
<<<<<<< HEAD
        for (int i = 0; i < tabCount; i++)
        {
            sb.Append(AllStrings.tab);
        }
=======
        for (var i = 0; i < tabCount; i++) sb.Append(AllStrings.tab);
>>>>>>> 29d1e5be02b542c7c9284024ef8bdf374aca4aff
    }

    private void Add(int tabCount, string v, string name, CssProperty[] cssProps)
    {
        AddTab(tabCount);
<<<<<<< HEAD
        sb.AppendLine(v +name + " {");
=======
        sb.AppendLine(v + name + " {");
>>>>>>> 29d1e5be02b542c7c9284024ef8bdf374aca4aff
        foreach (var item in cssProps)
        {
            AddTab(tabCount + 1);
            sb.AppendLine(PropertiesConversions.Convert(item.Property.ToString()) + ": " + item.Value + ";");
        }
<<<<<<< HEAD
        sbSH.TrimEnd();
=======

        //sb.TrimEnd();
>>>>>>> 29d1e5be02b542c7c9284024ef8bdf374aca4aff
        End(tabCount);
    }

    public void End(int tabCount)
    {
        sb.AppendLine();
        AddTab(tabCount);
        sb.AppendLine(AllStrings.rcub);
        sb.AppendLine();
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 29d1e5be02b542c7c9284024ef8bdf374aca4aff
