// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class TWithName
{
    public static TWithNameT<object> Get(string nameCb)
    {
        return new TWithNameT<object> { name = nameCb };
    }
}