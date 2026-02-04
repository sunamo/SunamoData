namespace SunamoData.Data;

/// <summary>
/// Represents a value of type T with an associated size as a string.
/// </summary>
/// <typeparam name="T">The type of the value.</typeparam>
public class TWithSizeInString<T>
{
    /// <summary>
    /// Gets or sets the size as a string (e.g., "10 MB", "5.2 GB").
    /// </summary>
    public string SizeS { get; set; } = "";

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public T Value { get; set; } = default!;

    /// <summary>
    /// Returns a string representation showing the value and size.
    /// </summary>
    /// <returns>A string in the format "Value (Size)".</returns>
    public override string ToString()
    {
        return Value + " (" + SizeS + ")";
    }
}