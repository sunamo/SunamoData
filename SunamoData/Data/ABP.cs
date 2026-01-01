namespace SunamoData.Data;

/// <summary>
/// Abbreviation for AB Property - contains properties instead of public variables.
/// </summary>
public class ABP
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ABP"/> class.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    public ABP(string key, object value)
    {
        Key = key;
        Value = value;
    }

    /// <summary>
    /// Gets or sets the key.
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public object Value { get; set; }

    /// <summary>
    /// Creates a new instance of ABP with the specified key and value.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns>A new ABP instance.</returns>
    public static ABP Get(string key, object value)
    {
        return new ABP(key, value);
    }
}
