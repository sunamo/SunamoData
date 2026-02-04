namespace SunamoData.Data;

/// <summary>
/// Represents a value of type T with an associated path.
/// </summary>
/// <typeparam name="T">The type of the value.</typeparam>
public class TWithPath<T>
{
    /// <summary>
    /// Gets or sets the path.
    /// </summary>
    public string Path { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public T Value { get; set; } = default!;
}