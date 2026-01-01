namespace SunamoData.Data;

/// <summary>
/// Represents a photo file name convention with a text prefix and optional number.
/// </summary>
public class PhotoFileNameConvention
{
    /// <summary>
    /// Gets or sets the optional number portion of the file name.
    /// </summary>
    public uint? Number { get; set; } = null;

    /// <summary>
    /// Gets or sets the text prefix of the file name.
    /// </summary>
    public string Text { get; set; } = "";

    #region Constants - photo file name prefixes that follow letter(s) + number convention - must check for lowercase as well

    /// <summary>
    /// DSC prefix constant.
    /// </summary>
    public const string DSC = "DSC";

    /// <summary>
    /// DSC_ prefix constant.
    /// </summary>
    public const string DSC_ = "DSC_";

    /// <summary>
    /// DSCN prefix constant.
    /// </summary>
    public const string DSCN = "DSCN";

    /// <summary>
    /// YDXJ prefix constant.
    /// </summary>
    public const string YDXJ = "YDXJ";

    /// <summary>
    /// P prefix constant.
    /// </summary>
    public const string P = "P";

    /// <summary>
    /// DSC (with space) prefix constant.
    /// </summary>
    public const string DSC__ = "DSC ";

    #endregion
}
