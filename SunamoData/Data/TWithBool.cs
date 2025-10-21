// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class TWithBool<T> //: ITWithDt<T>
{
    public T t { get; set; } = default;
    public bool b { get; set; }
}