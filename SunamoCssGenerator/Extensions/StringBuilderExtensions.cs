// variables names: ok
namespace SunamoCssGenerator.Extensions;

/// <summary>
/// Extension methods for StringBuilder
/// </summary>
public static class StringBuilderExtensions
{
    #region For easy copy

    /// <summary>
    /// Removes all trailing whitespace characters from the StringBuilder
    /// </summary>
    /// <param name="stringBuilder">The StringBuilder to trim</param>
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