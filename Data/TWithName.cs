namespace
#if SunamoDevCode
SunamoDevCode
#else SunamoDataData
SunamoDataData
#endif
;

public class TWithName
{
    public static TWithName<object> Get(string nameCb)
    {
        return new TWithName<object> { name = nameCb };
    }
}