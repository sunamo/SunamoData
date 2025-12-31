namespace SunamoData.Data;

public class FileInfoLite
{
    public string Directory;

    /// <summary>
    ///     EN: File name without path with extension and series
    ///     CZ: Název souboru bez cesty s příponou a sériemi
    /// </summary>
    public string Name;

    /// <summary>
    ///     EN: Full path to file
    ///     CZ: Plná cesta k souboru
    /// </summary>
    public string Path;

    public long Size;

    public FileInfoLite()
    {
    }

    public FileInfoLite(string directory, string fileName, long length)
    {
        Directory = directory;
        Name = fileName;
        Size = length;
    }

    public string FileName => Name;

    public long Length => Size;

    public static FileInfoLite GetFIL(FileInfo fileInfo)
    {
        var result = new FileInfoLite();
        result.Name = fileInfo.Name;
        result.Path = fileInfo.FullName;
        result.Directory = fileInfo.DirectoryName;
        result.Size = fileInfo.Length;
        return result;
    }

    public static FileInfoLite GetFIL(string file)
    {
        var fileInfo = new FileInfo(file);
        return GetFIL(fileInfo);
    }
}