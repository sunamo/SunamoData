namespace SunamoData.Data;

/// <summary>
///     EN: Used for example in HostingManager
///     CZ: Used for example in HostingManager
/// </summary>
public class FileInfoDB : FileInfoLite
{
    public int Id = -1;

    public FileInfoDB(int id, string directory, string fileName, long length) : base(directory, fileName, length)
    {
        Id = id;
    }

    /// <summary>
    ///     EN: When I want to use only FileInfo, but have FileInfoDB type
    ///     CZ: Když chci jakoby použít pouze FileInfo, ale mít typ FileInfoDB
    /// </summary>
    public FileInfoDB(string directory, string fileName, long length)
        : base(directory, fileName, length)
    {
    }

    public override string ToString()
    {
        return System.IO.Path.Combine(Path, Name);
        //return UH.Combine(false, new string[] { Path, Name });
    }
}