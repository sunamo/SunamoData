namespace SunamoData.Data;

public class ABT<TKey, TValue>
{
    public TKey Key;
    public TValue Value;

    public ABT(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }

    public ABT()
    {
    }
}