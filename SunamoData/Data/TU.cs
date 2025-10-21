// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class TU<T, U>
{
    public T Key;
    public U Value;

    public TU()
    {
    }

    public TU(T key, U value)
    {
        Key = key;
        Value = value;
    }

    public static TU<T, U> Get(T key, U value)
    {
        return new TU<T, U>(key, value);
    }
}