namespace SunamoData.Data;

/// <summary>
/// Represents an HTTP posted file with its content and metadata.
/// </summary>
public class SunamoHttpPostedFile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SunamoHttpPostedFile"/> class.
    /// </summary>
    public SunamoHttpPostedFile()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SunamoHttpPostedFile"/> class with a stream.
    /// </summary>
    /// <param name="contentLength">The length of the content in bytes.</param>
    /// <param name="contentType">The MIME content type of the file.</param>
    /// <param name="fileName">The name of the file.</param>
    /// <param name="inputStream">The input stream containing the file data.</param>
    public SunamoHttpPostedFile(long contentLength, string contentType, string fileName, Stream inputStream)
    {
        this.ContentLength = contentLength;
        this.ContentType = contentType;

        var ms = new MemoryStream();
        inputStream.CopyTo(ms);

        Bytes = ms.ToArray().ToList();
        this.FileName = fileName;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SunamoHttpPostedFile"/> class with byte data.
    /// </summary>
    /// <param name="contentLength">The length of the content in bytes.</param>
    /// <param name="contentType">The MIME content type of the file.</param>
    /// <param name="fileName">The name of the file.</param>
    /// <param name="bytes">The byte data of the file.</param>
    public SunamoHttpPostedFile(long contentLength, string contentType, string fileName, List<byte> bytes)
    {
        this.ContentLength = contentLength;
        this.ContentType = contentType;
        Bytes = bytes;
        this.FileName = fileName;
    }

    /// <summary>
    /// Gets or sets the length of the content in bytes.
    /// </summary>
    public long ContentLength { get; set; }

    /// <summary>
    /// Gets or sets the MIME content type of the file.
    /// </summary>
    public string ContentType { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the byte data of the file.
    /// </summary>
    public List<byte> Bytes { get; set; } = new();

    /// <summary>
    /// Gets or sets the name of the file.
    /// </summary>
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// Saves the file to the specified filename asynchronously.
    /// </summary>
    /// <param name="filename">The path where the file should be saved.</param>
    public async Task SaveAs(string filename)
    {
        await File.WriteAllBytesAsync(filename, Bytes.ToArray());
    }
}
