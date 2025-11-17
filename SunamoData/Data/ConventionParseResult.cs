// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class ConventionParseResult<T, U, Z> where T : notnull where U : notnull
{
    public List<Z> fail = new();
    public Dictionary<T, Dictionary<U, List<Z>>> success = new();
}