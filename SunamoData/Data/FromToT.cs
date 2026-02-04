namespace SunamoData.Data;

/// <summary>
/// Generic range type with start and end values of type T.
/// Contains parsing and formatting methods for time ranges.
/// </summary>
/// <typeparam name="T">The struct type for the range values.</typeparam>
public class FromToT<T> : IParser where T : struct
{
    /// <summary>
    /// Gets or sets whether this instance is empty.
    /// </summary>
    public bool IsEmpty { get; set; }

    private long fromLong;

    /// <summary>
    /// Gets or sets how to interpret the range values (DateTime, Unix time, or None).
    /// </summary>
    public FromToUseData FromToUse { get; set; } = FromToUseData.DateTime;

    private long toLong;

    /// <summary>
    /// Initializes a new instance of the <see cref="FromToT{T}"/> class.
    /// </summary>
    public FromToT()
    {
        var type = typeof(T);
        if (type == typeof(int)) FromToUse = FromToUseData.None;
    }

    /// <summary>
    /// Initializes a new instance with empty state. Use Empty constant outside of class.
    /// </summary>
    /// <param name="isEmpty">Whether this instance is empty.</param>
    private FromToT(bool isEmpty) : this()
    {
        IsEmpty = isEmpty;
    }

    /// <summary>
    /// Initializes a new instance with the specified range values.
    /// </summary>
    /// <param name="from">The start value of the range.</param>
    /// <param name="to">The end value of the range.</param>
    /// <param name="fromToUse">How to interpret the values (DateTime for date/time, None for plain numbers).</param>
    public FromToT(T from, T to, FromToUseData fromToUse = FromToUseData.DateTime) : this()
    {
        From = from;
        To = to;
        FromToUse = fromToUse;
    }

    /// <summary>
    /// Gets or sets the start value of the range.
    /// </summary>
    public T From
    {
        get => (T)(dynamic)fromLong;
        set => fromLong = (long)(dynamic)value;
    }

    /// <summary>
    /// Gets or sets the end value of the range.
    /// </summary>
    public T To
    {
        get => (T)(dynamic)toLong;
        set => toLong = (long)(dynamic)value;
    }

    /// <summary>
    /// Gets the start value as a long integer.
    /// </summary>
    public long FromLong => fromLong;

    /// <summary>
    /// Gets the end value as a long integer.
    /// </summary>
    public long ToLong => toLong;


    /// <summary>
    /// Parses a time range string in format "HH:mm-HH:mm" or "HH:mm".
    /// After parsing, IsFilledWithData can be called to check if data was successfully parsed.
    /// </summary>
    /// <param name="text">The time range string to parse.</param>
    public void Parse(string text)
    {
        List<string> parts = null!;
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

    /// <summary>
    /// Checks whether this instance contains valid parsed data.
    /// </summary>
    /// <returns>True if the instance has valid data, false otherwise.</returns>
    public bool IsFilledWithData()
    {
        //From != 0 && - cant be, if entered 0-24 fails
        return toLong >= 0 && toLong != 0;
    }

    /// <summary>
    /// Converts time format string (HH:mm or HH) to seconds.
    /// Use DTHelperCs.ToShortTimeFromSeconds to convert back.
    /// </summary>
    /// <param name="text">The time string to convert.</param>
    /// <returns>The number of seconds.</returns>
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

    /// <summary>
    /// Returns a string representation of this range based on the FromToUse setting.
    /// </summary>
    /// <returns>A string representation of the range.</returns>
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

    /// <summary>
    /// Converts this range to a DateTime string representation.
    /// Override this method in derived classes to provide custom formatting.
    /// </summary>
    /// <returns>A DateTime string representation.</returns>
    protected virtual string ToStringDateTime()
    {
        return "";
    }
}