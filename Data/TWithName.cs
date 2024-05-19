namespace
#if SunamoDevCode
SunamoDevCode
#else
SunamoData
#endif
;

public class TWithName
{
    public static TWithNameT<object> Get(string nameCb)
    {
        return new TWithNameT<object> { name = nameCb };
    }
}