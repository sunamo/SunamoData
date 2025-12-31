namespace SunamoData.Data;

public class FileInfoSerie : FileInfoLite
{
    /// <summary>
    ///     Pouze název souboru s příponou bez cesty, za to modifikovaný
    /// </summary>
    public string FileNameComplet;

    public bool HasSerie;
    public bool IsDeleted = false;
    public string NameWithoutSeries;

    public bool NeverRemove = false;

    //public string NameWithoutSeriesLower = null;
    public string PathWithoutSerie;

    public static FileInfoSerie GetFIS(string file,
        Func<string, bool, SerieStyleData, (string, bool)> GetNameWithoutSeriesNoOut)
    {
        var fileInfo = new FileInfo(file);
        return GetFIS(fileInfo, GetNameWithoutSeriesNoOut);
    }

    public static FileInfoSerie GetFIS(FileInfo fileInfo,
        Func<string, bool, SerieStyleData, (string, bool)> GetNameWithoutSeriesNoOut)
    {
        var fil = new FileInfoSerie();
        fil.Name = fileInfo.Name;
        fil.Path = fileInfo.FullName;
        fil.Size = fileInfo.Length;
        var (name, hasSerieName) = GetNameWithoutSeriesNoOut(fil.Name, false, SerieStyleData.Brackets);
        var (path, hasSeriePath) = GetNameWithoutSeriesNoOut(fil.Name, false, SerieStyleData.Brackets);
        fil.NameWithoutSeries = name;
        fil.PathWithoutSerie = path;
        fil.HasSerie = hasSeriePath;
        fil.FileNameComplet = System.IO.Path.GetFileName(fileInfo.FullName);
        return fil;
    }
}