// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class TWithSizeInString<T>
{
    public string sizeS = "";
    public T t = default;

    public override string ToString()
    {
        return t + " (" + sizeS + ")";
    }
}