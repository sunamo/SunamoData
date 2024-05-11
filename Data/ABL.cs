
namespace SunamoData;

namespace
#if SunamoCollections
SunamoCollections
#else
    SunamoData.Data
#endif
;

public class ABL<T, U>
{
    public List<T> a;
    public List<T> b;
}