namespace
#if SunamoUriWebServices
SunamoUriWebServices
#else
SunamoData
#endif
;

public class AzureBuildUriArgs
{
    public string personalAccessToken = null;
    public bool withLogin = false;
}
