namespace SunamoData.Data;

public class TWithName
{
    public static TWithNameT<object> Get(string name)
    {
        return new TWithNameT<object> { Name = name };
    }
}