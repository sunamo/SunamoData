namespace
#if SunamoCompare
SunamoCompare
#elif SunamoFileSystem
SunamoFileSystem
#else
SunamoData
#endif
;
public class TWithInt<T>
{
    public T t = default;
    public int count = 0;
}