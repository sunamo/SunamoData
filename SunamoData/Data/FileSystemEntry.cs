namespace SunamoData.Data;

/// <summary>
/// Represents a file system entry (file or directory).
/// Classes which handle file:
/// FileInfoDB->FileInfo
/// FileInfoSerie->FileInfoLite
/// FileSystemEntry
/// StorageFile
/// </summary>
public class FileSystemEntry
{
    /// <summary>
    /// Gets or sets a value indicating whether this entry is a file (true) or directory (false).
    /// </summary>
    public bool IsFile { get; set; } = false;

    /// <summary>
    /// Gets or sets the path of the file system entry.
    /// </summary>
    public string Path { get; set; } = "";
}
