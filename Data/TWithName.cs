namespace SunamoData.Data;

public class TWithName
{
    public static TWithName<object> Get(string nameCb)
    {
        return new TWithName<object> { name = nameCb };
    }
}