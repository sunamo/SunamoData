namespace SunamoData.Data;

public class StringPaddingData
{
    /// <summary>
    ///     [0]
    /// </summary>
    public bool First = false;

    /// <summary>
    ///     [0]
    /// </summary>
    public char FirstChar = 'a';

    /// <summary>
    ///     [Length-1] (really last / poslední)
    /// </summary>
    public bool Last = false;

    /// <summary>
    ///     [Length-1] (really last / poslední)
    /// </summary>
    public char LastChar = 'a';

    public string Text = null;

    #region for cases like "xxx: "

    /// <summary>
    ///     [1]
    /// </summary>
    public bool First2 = false;

    /// <summary>
    ///     [Length-2] (penultimate / předposlední)
    /// </summary>
    public bool Last2 = false;

    /// <summary>
    ///     [1]
    /// </summary>
    public char FirstChar2 = 'a';

    /// <summary>
    ///     [Length-2] (penultimate / předposlední)
    /// </summary>
    public char LastChar2 = 'a';

    #endregion
}