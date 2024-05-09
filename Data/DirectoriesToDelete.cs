namespace
#if SunamoFluentFtp
SunamoFluentFtp
#elif SunamoFtp
SunamoFtp
#else SunamoDataData
SunamoDataData
#endif
;

public class DirectoriesToDelete
{
    public int hloubka = 0;
    public List<Dictionary<string, List<string>>> adresare = new List<Dictionary<string, List<string>>>();
}
