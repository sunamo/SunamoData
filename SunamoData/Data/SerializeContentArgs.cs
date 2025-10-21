// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class SerializeContentArgs
{
    public string separatorString = "|";

    /// <summary>
    ///     Must be property - I can forget change value on three occurences.
    /// </summary>
    public char separatorChar => separatorString[0];

    public int keyCodeSeparator => separatorChar;
}