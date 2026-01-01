namespace SunamoData.Data;

/// <summary>
/// Represents a photo from a photo gallery with link and thumbnail information.
/// </summary>
public class PGPhoto
{
    /// <summary>
    /// Gets or sets the link URL to the full-size photo.
    /// </summary>
    public string Link { get; set; } = "";

    /// <summary>
    /// Gets or sets the name of the photo.
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    /// Gets or sets the thumbnail URL.
    /// </summary>
    public string Tn { get; set; } = "";
}