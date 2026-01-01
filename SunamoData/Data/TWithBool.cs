namespace SunamoData.Data;

/// <summary>
/// Represents a value of type T with an associated boolean.
/// </summary>
/// <typeparam name="T">The type of the value.</typeparam>
public class TWithBool<T>
{
    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public T Value { get; set; } = default!;

    /// <summary>
    /// Gets or sets the boolean value.
    /// </summary>
    public bool Bool { get; set; }
}
