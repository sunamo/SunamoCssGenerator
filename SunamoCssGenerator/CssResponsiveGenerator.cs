namespace SunamoCssGenerator;

/// <summary>
/// Represents the css responsive generator type.
/// </summary>
public class CssResponsiveGenerator : CssGenerator
{
    /// <summary>
    /// The sizes.
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
    public override string ToString() => base.ToString();

    /// <summary>
    /// Generate.
    /// </summary>
    /// <returns>The generate result.</returns>
    public void Generate(Dictionary<int, Dictionary<string, int>> elementWidthsByMaxWidth)
    {
        foreach (var maxWidth in Sizes.Skip(2))
        {
            AddMediaMinMaxWidth(0, maxWidth, GetMinFromMax);
            foreach (var element in elementWidthsByMaxWidth[maxWidth]) AddId(1, element.Key, CssProps.Width(element.Value + "px"));
            End(0);
        }
    }

    private int GetMinFromMax(int maxWidth)
    {
        var currentIndex = Sizes.IndexOf(maxWidth);
        return Sizes[currentIndex - 1] + 1;
    }

    #region From https: //en.wikipedia.org/wiki/List_of_common_resolutions

    /// <summary>
    /// The 768 constant.
    /// </summary>
    public const int _768 = 768;
    /// <summary>
    /// The 1024 constant.
    /// </summary>
    public const int _1024 = 1024;
    /// <summary>
    /// The 1280 constant.
    /// </summary>
    public const int _1280 = 1280;
    /// <summary>
    /// The 1366 constant.
    /// </summary>
    public const int _1366 = 1366;
    /// <summary>
    /// The 1440 constant.
    /// </summary>
    public const int _1440 = 1440;
    /// <summary>
    /// The 1536 constant.
    /// </summary>
    public const int _1536 = 1536;
    /// <summary>
    /// The 1600 constant.
    /// </summary>
    public const int _1600 = 1600;
    /// <summary>
    /// The 1792 constant.
    /// </summary>
    public const int _1792 = 1792;
    /// <summary>
    /// The 1920 constant.
    /// </summary>
    public const int _1920 = 1920;
    /// <summary>
    /// The 2048 constant.
    /// </summary>
    public const int _2048 = 2048;

    /// <summary>
    /// The 2160 constant.
    /// </summary>
    public const int _2160 = 2160;
    /// <summary>
    /// The 2280 constant.
    /// </summary>
    public const int _2280 = 2280;
    /// <summary>
    /// The 2304 constant.
    /// </summary>
    public const int _2304 = 2304;
    /// <summary>
    /// The 2436 constant.
    /// </summary>
    public const int _2436 = 2436;
    /// <summary>
    /// The 2560 constant.
    /// </summary>
    public const int _2560 = 2560;
    /// <summary>
    /// The 2732 constant.
    /// </summary>
    public const int _2732 = 2732;
    /// <summary>
    /// The 2880 constant.
    /// </summary>
    public const int _2880 = 2880;
    /// <summary>
    /// The 2960 constant.
    /// </summary>
    public const int _2960 = 2960;
    /// <summary>
    /// The 3200 constant.
    /// </summary>
    public const int _3200 = 3200;
    /// <summary>
    /// The 3440 constant.
    /// </summary>
    public const int _3440 = 3440;
    /// <summary>
    /// The 3840 constant.
    /// </summary>
    public const int _3840 = 3840;
    /// <summary>
    /// The 4096 constant.
    /// </summary>
    public const int _4096 = 4096;
    /// <summary>
    /// The 4480 constant.
    /// </summary>
    public const int _4480 = 4480;
    /// <summary>
    /// The 5120 constant.
    /// </summary>
    public const int _5120 = 5120;
    /// <summary>
    /// The 6016 constant.
    /// </summary>
    public const int _6016 = 6016;
    /// <summary>
    /// The 6040 constant.
    /// </summary>
    public const int _6040 = 6040;
    /// <summary>
    /// The 7680 constant.
    /// </summary>
    public const int _7680 = 7680;
    /// <summary>
    /// The 8192 constant.
    /// </summary>
    public const int _8192 = 8192;
    /// <summary>
    /// The 10240 constant.
    /// </summary>
    public const int _10240 = 10240;
    /// <summary>
    /// The 15360 constant.
    /// </summary>
    public const int _15360 = 15360;
    /// <summary>
    /// The 20000 constant.
    /// </summary>
    public const int _20000 = 20000;

    #endregion
}
