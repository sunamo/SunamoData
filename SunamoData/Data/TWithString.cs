namespace SunamoData.Data;

/// <summary>
/// Represents a value of type T with an associated string path.
/// </summary>
/// <typeparam name="T">The type of the value.</typeparam>
public class TWithString<T>
{
    /// <summary>
    /// Gets or sets the path.
    /// </summary>
    public string Path { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public T Value { get; set; } = default!;

    /// <summary>
    /// Initializes a new instance of the <see cref="TWithString{T}"/> class.
    /// </summary>
    public TWithString()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TWithString{T}"/> class with a value and path.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="path">The path.</param>
    public TWithString(T value, string path)
    {
        Value = value;
        Path = path;
    }

    /// <summary>
    /// Returns the path as the string representation.
    /// </summary>
    /// <returns>The path.</returns>
    public override string ToString()
    {
        return Path;
    }
}