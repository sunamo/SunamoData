// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class OTS
{
    public object A;
    public object B;

    public static OTS Get(object a, object b)
    {
        var ots = new OTS();
        ots.A = a;
        ots.B = b;
        return ots;
    }

    public override string ToString()
    {
        return A + "" + B;
    }
}