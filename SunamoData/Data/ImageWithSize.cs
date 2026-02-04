namespace SunamoData.Data;

/// <summary>
/// Represents an image with its dimensions and identifier.
/// </summary>
public class ImageWithSize
{
    /// <summary>
    /// Gets or sets the height of the image in pixels.
    /// </summary>
    public int Height { get; set; } = 0;

    /// <summary>
    /// Gets or sets the unique identifier of the image.
    /// </summary>
    public int Id { get; set; } = 0;

    /// <summary>
    /// Gets or sets the URI of the image.
    /// </summary>
    public string Uri { get; set; } = "";

    /// <summary>
    /// Gets or sets the width of the image in pixels.
    /// </summary>
    public int Width { get; set; } = 0;

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>The string representation of the image ID.</returns>
    public override string ToString()
    {
        return Id.ToString();
    }
}