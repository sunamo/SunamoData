namespace SunamoData.Data;

public class AB
{
    public static Type Type = typeof(AB);
    public string Key;
    public object Value;

    public AB(string key, object value)
    {
        Key = key;
        Value = value;
    }

    public static AB Get(Type type, object value)
    {
        return new AB(type.FullName, value);
    }

    public static AB Get(string key, object value)
    {
        return new AB(key, value);
    }

    public override string ToString()
    {
        return Key + ":" + Value;
    }
}