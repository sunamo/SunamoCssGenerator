using System;
using System.Collections.Generic;
using System.Text;

public class CssProps
{
    public static CssProperty Width(string v)
    {
        return new CssProperty { Property = Properties.Width, Value = v };
    }

}
