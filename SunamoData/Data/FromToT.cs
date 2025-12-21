namespace SunamoData.Data;

/// <summary>
///     Contains methods which was earlier in FromToT
/// </summary>
/// <typeparam name="T"></typeparam>
public class FromToT<T> : IParser where T : struct
{
    public bool empty;
    protected long fromL;
    public FromToUseData ftUse = FromToUseData.DateTime;
    protected long toL;

    public FromToT()
    {
        var type = typeof(T);
        if (type == typeof(int)) ftUse = FromToUseData.None;
    }

    /// <summary>
    ///     Use Empty contstant outside of class
    /// </summary>
    /// <param name="empty"></param>
    private FromToT(bool empty) : this()
    {
        this.empty = empty;
    }

    /// <summary>
    ///     A3 true = DateTime
    ///     A3 False = None
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="ftUse"></param>
    public FromToT(T from, T to, FromToUseData ftUse = FromToUseData.DateTime) : this()
    {
        this.from = from;
        this.to = to;
        this.ftUse = ftUse;
    }

    public T from
    {
        get => (T)(dynamic)fromL;
        set => fromL = (long)(dynamic)value;
    }

    public T to
    {
        get => (T)(dynamic)toL;
        set => toL = (long)(dynamic)value;
    }

    public long FromL => fromL;
    public long ToL => toL;


    /// <summary>
    ///     After it could be called IsFilledWithData
    /// </summary>
    /// <param name="input"></param>
    public void Parse(string input)
    {
        List<string> v = null;
        if (input.Contains("-"))
            v = input.Split('-').ToList(); //SHSplit.SplitChar(input, new Char[] { '-' });
        else
            v = new List<string>(new[] { input });
        if (v[0] == "0") v[0] = "00:01";
        if (v[1] == "24") v[1] = "23:59";
        var v0 = (long)ReturnSecondsFromTimeFormat(v[0]);
        fromL = v0;
        if (v.Count > 1)
        {
            var v1 = (long)ReturnSecondsFromTimeFormat(v[1]);
            toL = v1;
        }
    }

    public bool IsFilledWithData()
    {
        //from != 0 && - cant be, if entered 0-24 fails
        return toL >= 0 && toL != 0;
    }

    /// <summary>
    ///     Use DTHelperCs.ToShortTimeFromSeconds to convert back
    /// </summary>
    /// <param name="v"></param>
    /// <returns></returns>
    private int ReturnSecondsFromTimeFormat(string v)
    {
        var result = 0;
        if (v.Contains(":"))
        {
            var parts = v.Split(':').ToList()
                .ConvertAll(d => int.Parse(d)); //SHSplit.SplitToIntList(v, new String[] { ":" });
            result += parts[0] * (int)DTConstants.secondsInHour;
            if (parts.Count > 1) result += parts[1] * (int)DTConstants.secondsInMinute;
        }
        else
        {
            if (int.TryParse(v, out var _)) result += int.Parse(v) * (int)DTConstants.secondsInHour;
        }

        return result;
    }

    public override string ToString()
    {
        if (empty) return string.Empty;

        if (new List<FromToUseData>([FromToUseData.DateTime, FromToUseData.Unix, FromToUseData.UnixJustTime]).Any(d =>
            d == ftUse))
        {
            return ToStringDateTime();
        }
        else if (ftUse == FromToUseData.None)
        {
            return from + "-" + to;
        }
        else
        {
            ThrowEx.NotImplementedCase(ftUse);
            return string.Empty;
        }
    }

    protected virtual string ToStringDateTime()
    {
        return "";
    }
}