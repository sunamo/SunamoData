// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class StringPaddingData
{
    /// <summary>
    ///     [0]
    /// </summary>
    public bool first = false;

    /// <summary>
    ///     [0]
    /// </summary>
    public char firstChar = 'a';

    /// <summary>
    ///     [Length-1] (really last / poslední)
    /// </summary>
    public bool last = false;

    /// <summary>
    ///     [Length-1] (really last / poslední)
    /// </summary>
    public char lastChar = 'a';

    public string text = null;

    #region for cases like "xxx: "

    /// <summary>
    ///     [1]
    /// </summary>
    public bool first2 = false;

    /// <summary>
    ///     [Length-2] (penultimate / předposlední)
    /// </summary>
    public bool last2 = false;

    /// <summary>
    ///     [1]
    /// </summary>
    public char firstChar2 = 'a';

    /// <summary>
    ///     [Length-2] (penultimate / předposlední)
    /// </summary>
    public char lastChar2 = 'a';

    #endregion
}