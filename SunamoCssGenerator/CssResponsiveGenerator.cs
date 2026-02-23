namespace SunamoCssGenerator;

/// <summary>
/// Generates responsive CSS with media queries for common screen resolutions
/// </summary>
public class CssResponsiveGenerator : CssGenerator
{
    /// <summary>
    /// List of common screen widths in pixels for responsive breakpoints
    /// </summary>
    public static List<int> Sizes = new(new[]
    {
        _768,
        _1024,
        _1280,
        _1366,
        _1440,
        _1536,
        _1600,
        _1920,
        _2160,
        _2280,
        _2304,
        _2436,
        _2560,
        _2732,
        _2880,
        _2960,
        _3200,
        _3440,
        _3840,
        _4096,
        _4480,
        _5120,
        _6016,
        _6040,
        _7680,
        _8192,
        _10240,
        _15360,
        _20000
    });

    /// <summary>
    /// Returns the generated responsive CSS as a string
    /// </summary>
    /// <returns>The generated CSS code</returns>
    public override string ToString()
    {
        return base.ToString();
    }

    /// <summary>
    /// Generates responsive CSS with media queries for different screen widths.
    /// The dictionary maps max-width breakpoints to element names and their widths.
    /// </summary>
    /// <param name="elementWidthsByMaxWidth">Dictionary where key is max-width breakpoint and value is a dictionary of element names to their widths</param>
    public void Generate(Dictionary<int, Dictionary<string, int>> elementWidthsByMaxWidth)
    {
        foreach (var maxWidth in Sizes.Skip(2))
        {
            AddMediaMinMaxWidth(0, maxWidth, GetMinFromMax);
            foreach (var element in elementWidthsByMaxWidth[maxWidth]) AddId(1, element.Key, CssProps.Width(element.Value + "px"));
            End(0);
        }
    }

    /// <summary>
    /// Calculates the minimum width from a maximum width by finding the previous breakpoint
    /// </summary>
    /// <param name="maxWidth">The maximum width in pixels</param>
    /// <returns>The minimum width (previous breakpoint + 1)</returns>
    private int GetMinFromMax(int maxWidth)
    {
        var currentIndex = Sizes.IndexOf(maxWidth);
        return Sizes[currentIndex - 1] + 1;
    }

    #region From https: //en.wikipedia.org/wiki/List_of_common_resolutions

    /// <summary>Screen width breakpoint: 768px (tablets in portrait mode)</summary>
    public const int _768 = 768;
    /// <summary>Screen width breakpoint: 1024px (tablets in landscape mode, small laptops)</summary>
    public const int _1024 = 1024;
    /// <summary>Screen width breakpoint: 1280px (standard laptops, HD resolution)</summary>
    public const int _1280 = 1280;
    /// <summary>Screen width breakpoint: 1366px (common laptop resolution)</summary>
    public const int _1366 = 1366;
    /// <summary>Screen width breakpoint: 1440px (wide laptop screens)</summary>
    public const int _1440 = 1440;
    /// <summary>Screen width breakpoint: 1536px (scaled desktop displays)</summary>
    public const int _1536 = 1536;
    /// <summary>Screen width breakpoint: 1600px (wide desktop displays)</summary>
    public const int _1600 = 1600;
    /// <summary>Screen width breakpoint: 1792px (high-resolution displays)</summary>
    public const int _1792 = 1792;
    /// <summary>Screen width breakpoint: 1920px (Full HD resolution)</summary>
    public const int _1920 = 1920;
    /// <summary>Screen width breakpoint: 2048px (2K resolution)</summary>
    public const int _2048 = 2048;

    /// <summary>Screen width breakpoint: 2160px (ultra-wide displays)</summary>
    public const int _2160 = 2160;
    /// <summary>Screen width breakpoint: 2280px (high-resolution mobile displays)</summary>
    public const int _2280 = 2280;
    /// <summary>Screen width breakpoint: 2304px (Retina displays)</summary>
    public const int _2304 = 2304;
    /// <summary>Screen width breakpoint: 2436px (iPhone X-class displays)</summary>
    public const int _2436 = 2436;
    /// <summary>Screen width breakpoint: 2560px (QHD/WQHD resolution)</summary>
    public const int _2560 = 2560;
    /// <summary>Screen width breakpoint: 2732px (iPad Pro resolution)</summary>
    public const int _2732 = 2732;
    /// <summary>Screen width breakpoint: 2880px (Retina 5K displays)</summary>
    public const int _2880 = 2880;
    /// <summary>Screen width breakpoint: 2960px (high-resolution mobile displays)</summary>
    public const int _2960 = 2960;
    /// <summary>Screen width breakpoint: 3200px (ultra-high-resolution displays)</summary>
    public const int _3200 = 3200;
    /// <summary>Screen width breakpoint: 3440px (ultra-wide QHD displays)</summary>
    public const int _3440 = 3440;
    /// <summary>Screen width breakpoint: 3840px (4K UHD resolution)</summary>
    public const int _3840 = 3840;
    /// <summary>Screen width breakpoint: 4096px (DCI 4K resolution)</summary>
    public const int _4096 = 4096;
    /// <summary>Screen width breakpoint: 4480px (ultra-high-resolution displays)</summary>
    public const int _4480 = 4480;
    /// <summary>Screen width breakpoint: 5120px (5K resolution)</summary>
    public const int _5120 = 5120;
    /// <summary>Screen width breakpoint: 6016px (Apple Pro Display XDR resolution)</summary>
    public const int _6016 = 6016;
    /// <summary>Screen width breakpoint: 6040px (ultra-high-resolution displays)</summary>
    public const int _6040 = 6040;
    /// <summary>Screen width breakpoint: 7680px (8K UHD resolution)</summary>
    public const int _7680 = 7680;
    /// <summary>Screen width breakpoint: 8192px (8K Full resolution)</summary>
    public const int _8192 = 8192;
    /// <summary>Screen width breakpoint: 10240px (10K resolution)</summary>
    public const int _10240 = 10240;
    /// <summary>Screen width breakpoint: 15360px (16K resolution)</summary>
    public const int _15360 = 15360;
    /// <summary>Screen width breakpoint: 20000px (maximum supported resolution)</summary>
    public const int _20000 = 20000;

    #endregion
}