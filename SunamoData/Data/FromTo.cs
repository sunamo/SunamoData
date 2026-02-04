namespace SunamoData.Data;

/// <summary>
/// Represents a range with start and end values using long integers.
/// Must always have both from and to values entered. No event can have unlimited time!
/// </summary>
public class FromTo : FromToT<long>
{
    /// <summary>
    /// Gets an empty FromTo instance.
    /// </summary>
    public static FromTo Empty = new(true);

    /// <summary>
    /// Initializes a new instance of the <see cref="FromTo"/> class.
    /// </summary>
    public FromTo()
    {
    }

    /// <summary>
    /// Initializes a new instance with empty state. Use Empty constant outside of class.
    /// </summary>
    /// <param name="isEmpty">Whether this instance is empty.</param>
    private FromTo(bool isEmpty)
    {
        IsEmpty = isEmpty;
    }

    /// <summary>
    /// Initializes a new instance with the specified range values.
    /// </summary>
    /// <param name="from">The start value of the range.</param>
    /// <param name="to">The end value of the range.</param>
    /// <param name="fromToUse">How to interpret the values (DateTime, Unix time, or None).</param>
    public FromTo(long from, long to, FromToUseData fromToUse = FromToUseData.DateTime)
    {
        From = from;
        To = to;
        FromToUse = fromToUse;
    }
}