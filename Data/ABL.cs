

namespace
#if SunamoCollections
SunamoCollections
#elif SunamoData
SunamoData
#else
SunamoData.Data
#endif
;

public class ABL<T, U>
{
    public List<T> a;
    public List<T> b;
}
