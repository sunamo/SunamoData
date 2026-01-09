// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Represents a value of type T with an associated name.
/// </summary>
/// <typeparam name="T">The type of the value.</typeparam>
public class TWithNameT<T>
{
    /// <summary>
    /// Gets or sets the name (just first 5 letters in some contexts).
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public T Value { get; set; } = default!;

    /// <summary>
    /// Initializes a new instance of the <see cref="TWithNameT{T}"/> class.
    /// </summary>
    public TWithNameT()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TWithNameT{T}"/> class with a name and value.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="value">The value.</param>
    public TWithNameT(string name, T value)
    {
        Name = name;
        Value = value;
    }

    /// <summary>
    /// Returns the name as the string representation.
    /// </summary>
    /// <returns>The name.</returns>
    public override string ToString()
    {
        return Name;
    }

    /// <summary>
    /// Creates a new TWithNameT instance with the specified name.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns>A new TWithNameT&lt;T&gt; instance.</returns>
    public static TWithNameT<T> Get(string name)
    {
        return new TWithNameT<T> { Name = name };
    }
}