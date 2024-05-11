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
