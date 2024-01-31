namespace SunamoData.Data;

public class FileInfoSerie : FileInfoLite
{
    public bool IsDeleted = false;
    public string NameWithoutSeries = null;
    //public string NameWithoutSeriesLower = null;
    public string PathWithoutSerie = null;
    public bool HasSerie = false;
    /// <summary>
    /// Pouze název souboru s příponou bez cesty, za to modifikovaný
    /// </summary>
    public string FileNameComplet = null;
    public bool NeverRemove = false;

    public static FileInfoSerie GetFIS(string file, Func<string, bool, SerieStyle, (string, bool)> GetNameWithoutSeriesNoOut)
    {
        FileInfo item2 = new FileInfo(file);
        return GetFIS(item2, GetNameWithoutSeriesNoOut);
    }

    public static FileInfoSerie GetFIS(FileInfo item2, Func<string, bool, SerieStyle, (string, bool)> GetNameWithoutSeriesNoOut)
    {
        FileInfoSerie fil = new FileInfoSerie();
        fil.Name = item2.Name;
        fil.Path = item2.FullName;
        fil.Size = item2.Length;
        var (name, hasSerieName) = GetNameWithoutSeriesNoOut(fil.Name, false, SerieStyle.Brackets);
        var (path, hasSeriePath) = GetNameWithoutSeriesNoOut(fil.Name, false, SerieStyle.Brackets);
        fil.NameWithoutSeries = name;
        fil.PathWithoutSerie = path;
        fil.HasSerie = hasSeriePath;
        fil.FileNameComplet = System.IO.Path.GetFileName(item2.FullName);
        return fil;
    }
}
