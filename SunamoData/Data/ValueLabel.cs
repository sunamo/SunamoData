namespace SunamoData.Data;

public class ValueLabel
{
    public ValueLabel(string value, string label)
    {
        this.Value = value;
        this.Label = label;
    }

    public string Value { get; set; }

    public string Label { get; set; }

    /// <summary>
    ///     Ginstantion O AB
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public static ValueLabel Get(string value, string label)
    {
        return new ValueLabel(value, label);
    }
}