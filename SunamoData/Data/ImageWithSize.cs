// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class ImageWithSize
{
    public int height = 0;
    public int id = 0;
    public string uri = "";
    public int width = 0;

    public override string ToString()
    {
        return id.ToString();
    }
}