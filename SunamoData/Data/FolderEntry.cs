// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Represents a folder entry with its relative path.
/// </summary>
public class FolderEntry
{
    /// <summary>
    /// Gets or sets the relative path of the folder.
    /// This is actually a relative full path, so that by simply getting the parent node and root, the entire path can be obtained.
    /// </summary>
    public string RelativePath { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FolderEntry"/> class.
    /// </summary>
    /// <param name="relativePath">The relative path of the folder.</param>
    public FolderEntry(string relativePath)
    {
        this.RelativePath = relativePath;
    }
}