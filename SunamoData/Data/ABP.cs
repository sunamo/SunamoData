// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

/// <summary>
///     Je to zkratka AB Property - obsahuje vlastnosti místo veřejných proměnných
/// </summary>
public class ABP
{
    public ABP(string a, object b)
    {
        A = a;
        B = b;
    }

    public string A { get; set; }

    public object B { get; set; }

    /// <summary>
    ///     Ginstantion O AB
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public static ABP Get(string a, object b)
    {
        return new ABP(a, b);
    }
}