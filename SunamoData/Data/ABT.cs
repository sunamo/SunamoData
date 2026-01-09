// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Represents a generic key-value pair with types TKey and TValue.
/// </summary>
/// <typeparam name="TKey">The type of the key.</typeparam>
/// <typeparam name="TValue">The type of the value.</typeparam>
public class ABT<TKey, TValue>
{
    /// <summary>
    /// Gets or sets the key.
    /// </summary>
    public TKey Key { get; set; } = default!;

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public TValue Value { get; set; } = default!;

    /// <summary>
    /// Initializes a new instance of the <see cref="ABT{TKey, TValue}"/> class with the specified key and value.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    public ABT(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ABT{TKey, TValue}"/> class.
    /// </summary>
    public ABT()
    {
    }
}