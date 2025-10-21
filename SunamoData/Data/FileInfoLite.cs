// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class FileInfoLite
{
    public string Directory;

    /// <summary>
    ///     Název souboru bez cesty s příponou a sériemi
    /// </summary>
    public string Name;

    /// <summary>
    ///     Plná cesta k souboru
    /// </summary>
    public string Path;

    public long Size;

    public FileInfoLite()
    {
    }

    public FileInfoLite(string Directory, string FileName, long Length)
    {
        this.Directory = Directory;
        Name = FileName;
        Size = Length;
    }

    public string FileName => Name;

    public long Length => Size;

    public static FileInfoLite GetFIL(FileInfo item2)
    {
        var fil = new FileInfoLite();
        fil.Name = item2.Name;
        fil.Path = item2.FullName;
        fil.Directory = item2.DirectoryName;
        fil.Size = item2.Length;
        return fil;
    }

    public static FileInfoLite GetFIL(string file)
    {
        var item2 = new FileInfo(file);
        return GetFIL(item2);
    }
}