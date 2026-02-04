namespace SunamoData.Data;

/// <summary>
/// Base class for parsing string content into two typed values.
/// </summary>
/// <typeparam name="T1">The type of the first parsed value.</typeparam>
/// <typeparam name="T2">The type of the second parsed value.</typeparam>
public abstract class Parsing<T1, T2>
{
    /// <summary>
    /// Gets or sets the first parsed value.
    /// </summary>
    public T1? FirstValue { get; set; } = default;

    /// <summary>
    /// Gets or sets the second parsed value.
    /// </summary>
    public T2? SecondValue { get; set; } = default;

    /// <summary>
    /// Parses the content string and populates FirstValue and SecondValue.
    /// </summary>
    /// <param name="content">The string content to parse.</param>
    public abstract void Parse(string content);
}