namespace SunamoData.Data;

public class ConventionParseResult<T, U, Z>
{
    public List<Z> fail = new();
    public Dictionary<T, Dictionary<U, List<Z>>> success = new();
}