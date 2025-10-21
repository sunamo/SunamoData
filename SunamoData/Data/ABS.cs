// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

/// <summary>
///     Implicitly are strings.Empty to avoid cheching data class for null
/// </summary>
public class ABS : ABT<string, string>
{
    public ABS()
    {
        A = B = string.Empty;
    }

    public ABS(string a, string b)
    {
        A = a;
        B = b;
    }
}