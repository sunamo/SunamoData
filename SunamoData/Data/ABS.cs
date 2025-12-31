namespace SunamoData.Data;

/// <summary>
///     EN: Implicitly are strings.Empty to avoid checking data class for null
///     CZ: Implicitly are strings.Empty to avoid cheching data class for null
/// </summary>
public class ABS : ABT<string, string>
{
    public ABS()
    {
        Key = Value = string.Empty;
    }

    public ABS(string key, string value)
    {
        Key = key;
        Value = value;
    }
}