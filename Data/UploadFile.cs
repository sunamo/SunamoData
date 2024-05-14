namespace
#if SunamoShared
SunamoShared
#elif SunamoFluentFtp
SunamoFluentFtp
#elif SunamoFtp
SunamoFtp
#elif SunamoFtp
SunamoFtp
#elif SunamoFtp
SunamoFtp
#else
SunamoData
#endif
;

public class UploadFile
{
    public UploadFile()
    {
        ContentType = "application/octet-stream";
    }
    public string Name { get; set; }
    public string Filename { get; set; }
    public string ContentType { get; set; }
    public Stream Stream { get; set; }
    //public long ContentLength { get; set; }
}
