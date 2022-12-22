using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class StringBuilderExtensions
{
    #region For easy copy
    public static void TrimEnd(this StringBuilder sb)
    {
        var length = sb.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            if (char.IsWhiteSpace(sb[i]))
            {
                sb.Remove(i, 1);
            }
            else
            {
                break;
            }
        }
    }
    #endregion
}
