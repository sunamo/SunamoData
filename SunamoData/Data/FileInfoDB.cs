namespace SunamoData.Data;

/// <summary>
/// Represents file information with a database identifier.
/// Used for example in HostingManager.
/// </summary>
public class FileInfoDB : FileInfoLite
{
    /// <summary>
    /// Gets or sets the database identifier for this file.
    /// </summary>
    public int Id { get; set; } = -1;

    /// <summary>
    /// Initializes a new instance of the <see cref="FileInfoDB"/> class with an ID.
    /// </summary>
    /// <param name="id">The database identifier.</param>
    /// <param name="directory">The directory path.</param>
    /// <param name="fileName">The file name.</param>
    /// <param name="length">The file size in bytes.</param>
    public FileInfoDB(int id, string directory, string fileName, long length) : base(directory, fileName, length)
    {
        Id = id;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FileInfoDB"/> class without an ID.
    /// When I want to use only FileInfo, but have FileInfoDB type.
    /// </summary>
    /// <param name="directory">The directory path.</param>
    /// <param name="fileName">The file name.</param>
    /// <param name="length">The file size in bytes.</param>
    public FileInfoDB(string directory, string fileName, long length)
        : base(directory, fileName, length)
    {
    }

    /// <summary>
    /// Returns the full path to the file.
    /// </summary>
    /// <returns>The combined path and file name.</returns>
    public override string ToString()
    {
        return System.IO.Path.Combine(Path, Name);
    }
}