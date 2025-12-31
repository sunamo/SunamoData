namespace SunamoData.Data;

public class SerializeContentArgs
{
    public string SeparatorString = "|";

    /// <summary>
    ///     Must be property - I can forget change value on three occurences.
    /// </summary>
    public char SeparatorChar => SeparatorString[0];

    public int KeyCodeSeparator => SeparatorChar;
}