namespace SunamoCssGenerator.Extensions;

/// <summary>
/// Represents the string builder extensions type.
/// </summary>
public static class StringBuilderExtensions
{
    #region For easy copy

    /// <summary>
    /// Trim end.
    /// </summary>
    /// <param name="stringBuilder">The string builder.</param>
    public static void TrimEnd(this StringBuilder stringBuilder)
    {
        var length = stringBuilder.Length;
        for (var i = length - 1; i >= 0; i--)
            if (char.IsWhiteSpace(stringBuilder[i]))
                stringBuilder.Remove(i, 1);
            else
                break;
    }

    #endregion
}
