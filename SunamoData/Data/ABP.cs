namespace SunamoData.Data;

/// <summary>
///     EN: Abbreviation for AB Property - contains properties instead of public variables
///     CZ: Je to zkratka AB Property - obsahuje vlastnosti místo veřejných proměnných
/// </summary>
public class ABP
{
    public ABP(string key, object value)
    {
        Key = key;
        Value = value;
    }

    public string Key { get; set; }

    public object Value { get; set; }

    /// <summary>
    ///     EN: Instantiation of AB
    ///     CZ: Ginstantion O AB
    /// </summary>
    public static ABP Get(string key, object value)
    {
        return new ABP(key, value);
    }
}