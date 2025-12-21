namespace SunamoData.Data;

public class TWithName
{
    public static TWithNameT<object> Get(string nameCb)
    {
        return new TWithNameT<object> { name = nameCb };
    }
}