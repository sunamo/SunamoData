namespace SunamoData.Data;

/// <summary>
/// Arguments for content serialization with configurable separator.
/// </summary>
public class SerializeContentArgs
{
    /// <summary>
    /// Gets or sets the separator string. Defaults to "|".
    /// </summary>
    public string SeparatorString { get; set; } = "|";

    /// <summary>
    /// Gets the first character of the separator string.
    /// Must be property - prevents forgetting to change value in three occurrences.
    /// </summary>
    public char SeparatorChar => SeparatorString[0];

    /// <summary>
    /// Gets the key code of the separator character.
    /// </summary>
    public int KeyCodeSeparator => SeparatorChar;
}
