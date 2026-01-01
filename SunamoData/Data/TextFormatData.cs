namespace SunamoData.Data;

/// <summary>
/// Alternatives: FormatOfString - allow as many as is chars in every match.
/// Can check whether on position is expected char (letter, digit, etc.) but then not allow variable length of parsed.
/// </summary>
public class TextFormatData : List<CharFormatData>
{
    /// <summary>
    /// Gets or sets the exact required length. Must not be shorter or longer.
    /// If -1, text can have any length.
    /// </summary>
    public int RequiredLength { get; set; } = -1;

    /// <summary>
    /// Gets or sets whether to trim the text before validation.
    /// </summary>
    public bool TrimBefore { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TextFormatData"/> class.
    /// Set requiredLength to -1 if text can have any length.
    /// </summary>
    /// <param name="isTrimming">Whether to trim the text before validation.</param>
    /// <param name="requiredLength">The exact required length (-1 for any length).</param>
    /// <param name="formatDataItems">Array of character format data items.</param>
    public TextFormatData(bool isTrimming, int requiredLength, params CharFormatData[] formatDataItems)
    {
        this.TrimBefore = isTrimming;
        this.RequiredLength = requiredLength;
        AddRange(formatDataItems);
    }

    /// <summary>
    /// Contains template TextFormatData configurations for common scenarios.
    /// </summary>
    public static class Templates
    {
    }
}
