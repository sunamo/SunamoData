namespace
#if SunamoDevCode
SunamoDevCode
#else
SunamoData
#endif
;

public class TWithName
{
    public static TWithName<object> Get(string nameCb)
    {
        return new TWithName<object> { name = nameCb };
    }
}