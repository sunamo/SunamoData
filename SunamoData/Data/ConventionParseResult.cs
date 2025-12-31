namespace SunamoData.Data;

public class ConventionParseResult<T, U, Z> where T : notnull where U : notnull
{
    public List<Z> Failed = new();
    public Dictionary<T, Dictionary<U, List<Z>>> Succeeded = new();
}