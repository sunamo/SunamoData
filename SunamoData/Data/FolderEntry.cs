// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class FolderEntry
{
    public string RelativePath;

    /// <summary>
    ///     A1 je skutečně relativní plná cesta, abych snadno mohl získat pouze získáním naduzlu a rootu celou cestu
    /// </summary>
    /// <param name="ID"></param>
    /// <param name="DirectoryName"></param>
    public FolderEntry(string RelativePath)
    {
        this.RelativePath = RelativePath;
    }
}