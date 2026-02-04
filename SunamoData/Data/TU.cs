namespace SunamoData.Data;

/// <summary>
/// Represents a generic key-value pair with types T and U.
/// </summary>
/// <typeparam name="T">The type of the key.</typeparam>
/// <typeparam name="U">The type of the value.</typeparam>
public class TU<T, U>
{
    /// <summary>
    /// Gets or sets the key.
    /// </summary>
    public T Key { get; set; } = default!;

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public U Value { get; set; } = default!;

    /// <summary>
    /// Initializes a new instance of the <see cref="TU{T, U}"/> class.
    /// </summary>
    public TU()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TU{T, U}"/> class with a key and value.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    public TU(T key, U value)
    {
        Key = key;
        Value = value;
    }

    /// <summary>
    /// Creates a new instance of <see cref="TU{T, U}"/> with the specified key and value.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns>A new instance of <see cref="TU{T, U}"/>.</returns>
    public static TU<T, U> Get(T key, U value)
    {
        return new TU<T, U>(key, value);
    }
}