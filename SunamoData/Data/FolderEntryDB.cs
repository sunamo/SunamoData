namespace SunamoData.Data;

/// <summary>
/// Represents a folder entry in a database with an ID and relative path.
/// </summary>
public class FolderEntryDB : FolderEntry
{
    /// <summary>
    /// Gets or sets the unique identifier for the folder entry in the database.
    /// </summary>
    public int ID { get; set; } = -1;

    /// <summary>
    /// Initializes a new instance of the <see cref="FolderEntryDB"/> class with an ID and relative path.
    /// </summary>
    /// <param name="id">The unique identifier for the folder entry.</param>
    /// <param name="relativePath">The relative path of the folder.</param>
    public FolderEntryDB(int id, string relativePath) : base(relativePath)
    {
        this.ID = id;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FolderEntryDB"/> class with only a relative path.
    /// </summary>
    /// <param name="relativePath">The relative path of the folder.</param>
    public FolderEntryDB(string relativePath)
        : base(relativePath)
    {
    }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>The relative path of the folder.</returns>
    public override string ToString()
    {
        return RelativePath;
    }
}