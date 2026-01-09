// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Data about string padding characters at specific positions.
/// </summary>
public class StringPaddingData
{
    /// <summary>
    /// Gets or sets whether to check the first character [0].
    /// </summary>
    public bool First { get; set; } = false;

    /// <summary>
    /// Gets or sets the expected first character [0].
    /// </summary>
    public char FirstChar { get; set; } = 'a';

    /// <summary>
    /// Gets or sets whether to check the last character [Length-1].
    /// </summary>
    public bool Last { get; set; } = false;

    /// <summary>
    /// Gets or sets the expected last character [Length-1].
    /// </summary>
    public char LastChar { get; set; } = 'a';

    /// <summary>
    /// Gets or sets the text to be validated.
    /// </summary>
    public string Text { get; set; } = "";

    #region for cases like "xxx: "

    /// <summary>
    /// Gets or sets whether to check the second character [1].
    /// </summary>
    public bool First2 { get; set; } = false;

    /// <summary>
    /// Gets or sets whether to check the penultimate character [Length-2].
    /// </summary>
    public bool Last2 { get; set; } = false;

    /// <summary>
    /// Gets or sets the expected second character [1].
    /// </summary>
    public char FirstChar2 { get; set; } = 'a';

    /// <summary>
    /// Gets or sets the expected penultimate character [Length-2].
    /// </summary>
    public char LastChar2 { get; set; } = 'a';

    #endregion
}