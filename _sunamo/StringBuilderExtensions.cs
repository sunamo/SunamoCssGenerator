namespace SunamoCssGenerator._sunamo;

internal static class StringBuilderExtensions
{
    #region For easy copy

    internal static void TrimEnd(this StringBuilder sb)
    {
        var length = sb.Length;
        for (var i = length - 1; i >= 0; i--)
            if (char.IsWhiteSpace(sb[i]))
                sb.Remove(i, 1);
            else
                break;
    }

    #endregion
}