namespace SunamoData.Data;

public class TWithString<T>
{
    public string Path;

    public T Value;

    public TWithString()
    {
    }

    public TWithString(T value, string path)
    {
        Value = value;
        Path = path;
    }

    public override string ToString()
    {
        return Path;
    }
}