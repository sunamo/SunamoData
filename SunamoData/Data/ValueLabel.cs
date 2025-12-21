namespace SunamoData.Data;

public class ValueLabel
{
    public ValueLabel(string value, string label)
    {
        this.value = value;
        this.label = label;
    }

    public string value { get; set; }

    public string label { get; set; }

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