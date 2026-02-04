namespace SunamoData.Data;

/// <summary>
/// Lightweight file information class containing basic file metadata.
/// </summary>
public class FileInfoLite
{
    /// <summary>
    /// Gets or sets the directory path.
    /// </summary>
    public string Directory { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the file name without path, with extension and series.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the full path to the file.
    /// </summary>
    public string Path { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the file size in bytes.
    /// </summary>
    public long Size { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FileInfoLite"/> class.
    /// </summary>
    public FileInfoLite()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FileInfoLite"/> class with specified values.
    /// </summary>
    /// <param name="directory">The directory path.</param>
    /// <param name="fileName">The file name.</param>
    /// <param name="length">The file size in bytes.</param>
    public FileInfoLite(string directory, string fileName, long length)
    {
        Directory = directory;
        Name = fileName;
        Size = length;
    }

    /// <summary>
    /// Gets the file name (alias for Name property).
    /// </summary>
    public string FileName => Name;

    /// <summary>
    /// Gets the file length in bytes (alias for Size property).
    /// </summary>
    public long Length => Size;

    /// <summary>
    /// Creates a FileInfoLite instance from a FileInfo object.
    /// </summary>
    /// <param name="fileInfo">The FileInfo object to convert.</param>
    /// <returns>A new FileInfoLite instance.</returns>
    public static FileInfoLite GetFIL(FileInfo fileInfo)
    {
        var result = new FileInfoLite();
        result.Name = fileInfo.Name;
        result.Path = fileInfo.FullName;
        result.Directory = fileInfo.DirectoryName ?? string.Empty;
        result.Size = fileInfo.Length;
        return result;
    }

    /// <summary>
    /// Creates a FileInfoLite instance from a file path.
    /// </summary>
    /// <param name="file">The file path.</param>
    /// <returns>A new FileInfoLite instance.</returns>
    public static FileInfoLite GetFIL(string file)
    {
        var fileInfo = new FileInfo(file);
        return GetFIL(fileInfo);
    }
}