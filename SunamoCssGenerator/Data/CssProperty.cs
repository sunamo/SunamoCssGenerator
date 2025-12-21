namespace SunamoCssGenerator.Data;

public class CssProperty(Properties property, string value)
{
    public Properties Property { get; set; } = property;
    public string Value { get; set; } = value;
}