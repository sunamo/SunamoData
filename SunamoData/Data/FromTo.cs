namespace SunamoData.Data;

/// <summary>
///     EN: Must have always entered both from and to. None of event could have unlimited time!
///     CZ: Must have always entered both from and to. None of event could have unlimited time!
/// </summary>
public class FromTo : FromToT<long>
{
    public static FromTo Empty = new(true);

    public FromTo()
    {
    }

    /// <summary>
    ///     EN: Use Empty constant outside of class
    ///     CZ: Use Empty contstant outside of class
    /// </summary>
    private FromTo(bool isEmpty)
    {
        IsEmpty = isEmpty;
    }

    /// <summary>
    ///     EN: A3 true = DateTime, A3 False = None
    ///     CZ: A3 true = DateTime, A3 False = None
    /// </summary>
    public FromTo(long from, long to, FromToUseData fromToUse = FromToUseData.DateTime)
    {
        From = from;
        To = to;
        FromToUse = fromToUse;
    }
}