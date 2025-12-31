namespace SunamoData.Data;

public class TWithNameT<T>
{
    /// <summary>
    ///     EN: Just first 5 letters
    ///     CZ: Just first 5. letters
    /// </summary>
    public string Name = string.Empty;

    public T Value;

    public TWithNameT()
    {
    }

    public TWithNameT(string name, T value)
    {
        Name = name;
        Value = value;
    }

    public override string ToString()
    {
        return Name;
    }

    public static TWithNameT<T> Get(string name)
    {
        return new TWithNameT<T> { Name = name };
    }
}