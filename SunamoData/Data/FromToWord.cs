namespace SunamoData.Data;

/// <summary>
/// Represents a word with its position range (from-to indices).
/// </summary>
public class FromToWord
{
    /// <summary>
    /// Gets or sets the start index of the word.
    /// </summary>
    public int From { get; set; } = 0;

    /// <summary>
    /// Gets or sets the end index of the word.
    /// </summary>
    public int To { get; set; } = 0;

    /// <summary>
    /// Gets or sets the word text.
    /// </summary>
    public string Word { get; set; } = "";
}