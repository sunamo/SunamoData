// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class PhotoToUpload
{
    public string Path { get; set; }

    public string PathSanitized { get; set; }

    //public int Size { get; set; }
    public DateTime DateTaken { get; set; }

    //public string IdPhoto { get; set; }
    public int OriginalSize { get; set; }

    // bytes is already sending in SunamoHttpPostedFile
    //public List<byte> Bytes { get; set; }
}