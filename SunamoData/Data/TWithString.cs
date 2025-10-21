// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class TWithString<T>
{
    public string path;

    public T t;

    public TWithString()
    {
    }

    public TWithString(T t, string path)
    {
        this.t = t;
        this.path = path;
    }

    public override string ToString()
    {
        return path;
    }
}