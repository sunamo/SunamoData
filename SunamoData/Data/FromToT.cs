namespace SunamoData.Data;

/// <summary>
///     EN: Contains methods which were earlier in FromToT
///     CZ: Contains methods which was earlier in FromToT
/// </summary>
public class FromToT<T> : IParser where T : struct
{
    public bool IsEmpty;
    protected long fromLong;
    public FromToUseData FromToUse = FromToUseData.DateTime;
    protected long toLong;

    public FromToT()
    {
        var type = typeof(T);
        if (type == typeof(int)) FromToUse = FromToUseData.None;
    }

    /// <summary>
    ///     EN: Use Empty constant outside of class
    ///     CZ: Use Empty contstant outside of class
    /// </summary>
    private FromToT(bool isEmpty) : this()
    {
        IsEmpty = isEmpty;
    }

    /// <summary>
    ///     EN: A3 true = DateTime, A3 False = None
    ///     CZ: A3 true = DateTime, A3 False = None
    /// </summary>
    public FromToT(T from, T to, FromToUseData fromToUse = FromToUseData.DateTime) : this()
    {
        From = from;
        To = to;
        FromToUse = fromToUse;
    }

    public T From
    {
        get => (T)(dynamic)fromLong;
        set => fromLong = (long)(dynamic)value;
    }

    public T To
    {
        get => (T)(dynamic)toLong;
        set => toLong = (long)(dynamic)value;
    }

    public long FromLong => fromLong;
    public long ToLong => toLong;


    /// <summary>
    ///     EN: After it can be called IsFilledWithData
    ///     CZ: After it could be called IsFilledWithData
    /// </summary>
    public void Parse(string text)
    {
        List<string> parts = null;
        if (text.Contains("-"))
            parts = text.Split('-').ToList(); //SHSplit.SplitChar(text, new Char[] { '-' });
        else
            parts = new List<string>(new[] { text });
        if (parts[0] == "0") parts[0] = "00:01";
        if (parts[1] == "24") parts[1] = "23:59";
        var fromSeconds = (long)ReturnSecondsFromTimeFormat(parts[0]);
        fromLong = fromSeconds;
        if (parts.Count > 1)
        {
            var toSeconds = (long)ReturnSecondsFromTimeFormat(parts[1]);
            toLong = toSeconds;
        }
    }

    public bool IsFilledWithData()
    {
        //From != 0 && - cant be, if entered 0-24 fails
        return toLong >= 0 && toLong != 0;
    }

    /// <summary>
    ///     EN: Use DTHelperCs.ToShortTimeFromSeconds to convert back
    ///     CZ: Use DTHelperCs.ToShortTimeFromSeconds to convert back
    /// </summary>
    private int ReturnSecondsFromTimeFormat(string text)
    {
        var result = 0;
        if (text.Contains(":"))
        {
            var parts = text.Split(':').ToList()
                .ConvertAll(element => int.Parse(element)); //SHSplit.SplitToIntList(text, new String[] { ":" });
            result += parts[0] * (int)DTConstants.SecondsInHour;
            if (parts.Count > 1) result += parts[1] * (int)DTConstants.SecondsInMinute;
        }
        else
        {
            if (int.TryParse(text, out var _)) result += int.Parse(text) * (int)DTConstants.SecondsInHour;
        }

        return result;
    }

    public override string ToString()
    {
        if (IsEmpty) return string.Empty;

        if (new List<FromToUseData>([FromToUseData.DateTime, FromToUseData.Unix, FromToUseData.UnixJustTime]).Any(element =>
            element == FromToUse))
        {
            return ToStringDateTime();
        }
        else if (FromToUse == FromToUseData.None)
        {
            return From + "-" + To;
        }
        else
        {
            ThrowEx.NotImplementedCase(FromToUse);
            return string.Empty;
        }
    }

    protected virtual string ToStringDateTime()
    {
        return "";
    }
}