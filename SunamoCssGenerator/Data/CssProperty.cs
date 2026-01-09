// variables names: ok
namespace SunamoCssGenerator.Data;

/// <summary>
/// Represents a CSS property with its name and value
/// </summary>
public class CssProperty(Properties property, string value)
{
    /// <summary>
    /// Gets or sets the CSS property name
    /// </summary>
    public Properties Property { get; set; } = property;

    /// <summary>
    /// Gets or sets the CSS property value
    /// </summary>
    public string Value { get; set; } = value;
}