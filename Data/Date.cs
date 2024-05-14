namespace
#if SunamoDateTime
SunamoDateTime
#elif SunamoDevCode
SunamoDevCode
#elif SunamoFubuCore
SunamoFubuCore
#elif SunamoShared
SunamoShared
#elif SunamoXlfKeys
SunamoXlfKeys
#elif SunamoValues
SunamoValues
#elif SunamoLang
SunamoLang
#elif SunamoEnums
SunamoEnums
#else
SunamoData
#endif
;

public class Date
{
    public int Day;
    public int Month;
    public int Year;
}
