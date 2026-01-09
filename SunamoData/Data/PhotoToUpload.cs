// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Represents a photo to be uploaded with path and metadata.
/// </summary>
public class PhotoToUpload
{
    /// <summary>
    /// Gets or sets the path to the photo file.
    /// </summary>
    public string Path { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the sanitized path to the photo file.
    /// </summary>
    public string PathSanitized { get; set; } = string.Empty;

    //public int Size { get; set; }

    /// <summary>
    /// Gets or sets the date when the photo was taken.
    /// </summary>
    public DateTime DateTaken { get; set; }

    //public string IdPhoto { get; set; }

    /// <summary>
    /// Gets or sets the original size of the photo in bytes.
    /// </summary>
    public int OriginalSize { get; set; }

    // bytes is already sending in SunamoHttpPostedFile
    //public List<byte> Bytes { get; set; }
}