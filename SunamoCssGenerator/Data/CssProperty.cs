namespace SunamoCssGenerator.Data;

/// <summary>
/// Css property.
/// </summary>
/// <param name="property">The property.</param>
/// <param name="value">The value.</param>
/// <returns>The css property result.</returns>
public class CssProperty(Properties property, string value)
{
    /// <summary>
    /// Gets or sets the property.
    /// </summary>
    public Properties Property { get; set; } = property;

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public string Value { get; set; } = value;
}
