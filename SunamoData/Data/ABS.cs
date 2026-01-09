// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Implicitly initialized to string.Empty to avoid checking data class for null.
/// </summary>
public class ABS : ABT<string, string>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ABS"/> class with empty strings.
    /// </summary>
    public ABS()
    {
        Key = Value = string.Empty;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ABS"/> class with the specified key and value.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    public ABS(string key, string value)
    {
        Key = key;
        Value = value;
    }
}