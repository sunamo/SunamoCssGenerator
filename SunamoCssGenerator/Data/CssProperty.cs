// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoCssGenerator.Data;

public class CssProperty(Properties property, string value)
{
    public Properties Property { get; set; } = property;
    public string Value { get; set; } = value;
}