// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Represents file information with serie information (file name patterns like "file (1).txt", "file (2).txt").
/// </summary>
public class FileInfoSerie : FileInfoLite
{
    /// <summary>
    /// Gets or sets the complete file name with extension but without path, possibly modified.
    /// </summary>
    public string FileNameComplet { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets whether this file has a serie number in its name.
    /// </summary>
    public bool HasSerie { get; set; }

    /// <summary>
    /// Gets or sets whether this file has been deleted.
    /// </summary>
    public bool IsDeleted { get; set; } = false;

    /// <summary>
    /// Gets or sets the file name without the serie number.
    /// </summary>
    public string NameWithoutSeries { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets whether this file should never be removed.
    /// </summary>
    public bool NeverRemove { get; set; } = false;

    /// <summary>
    /// Gets or sets the file path without the serie number.
    /// </summary>
    public string PathWithoutSerie { get; set; } = string.Empty;

    /// <summary>
    /// Creates a FileInfoSerie instance from a file path.
    /// </summary>
    /// <param name="file">The file path.</param>
    /// <param name="GetNameWithoutSeriesNoOut">Function to extract name without serie number.</param>
    /// <returns>A new FileInfoSerie instance.</returns>
    public static FileInfoSerie GetFIS(string file,
        Func<string, bool, SerieStyleData, (string, bool)> GetNameWithoutSeriesNoOut)
    {
        var fileInfo = new FileInfo(file);
        return GetFIS(fileInfo, GetNameWithoutSeriesNoOut);
    }

    /// <summary>
    /// Creates a FileInfoSerie instance from a FileInfo object.
    /// </summary>
    /// <param name="fileInfo">The FileInfo object.</param>
    /// <param name="GetNameWithoutSeriesNoOut">Function to extract name without serie number.</param>
    /// <returns>A new FileInfoSerie instance.</returns>
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