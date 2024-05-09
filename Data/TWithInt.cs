namespace
#if SunamoCompare
SunamoCompare
#elif SunamoFileSystem
SunamoFileSystem
#else
SunamoDataData
#endif
;

public class TWithInt<T>
{
    public T t = default;
    public int count = 0;
}
