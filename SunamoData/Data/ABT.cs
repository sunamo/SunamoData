// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class ABT<Key, Value>
{
    public Key A;
    public Value B;

    public ABT(Key a, Value b)
    {
        A = a;
        B = b;
    }

    public ABT()
    {
    }
}