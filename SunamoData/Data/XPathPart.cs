// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class XPathPart
{
    private static Type type = typeof(XPathPart);
    public string attName;
    public string attValue = "";
    public string tag;
    public XPathPart(string part)
    {
        var dexStartSquareBracket = part.IndexOf(']');
        var dexEndSquareBracket = part.IndexOf('[');
        if (dexStartSquareBracket != -1 && dexEndSquareBracket != -1)
        {
            tag = part.Substring(0, dexStartSquareBracket);
            var attr = part.Substring(dexStartSquareBracket + 1, dexEndSquareBracket - 1);
            if (attr != "")
                if (attr[0] == '@')
                {
                    var nameValue = SHSplit.SplitChar(attr.Substring(1), '"', '\\', '=');
                    if (nameValue.Count == 2)
                        if (nameValue[0] != "")
                        {
                            attName = nameValue[0];
                            attValue = nameValue[1];
                        }
                }
        }
        else if (dexStartSquareBracket == -1 && dexEndSquareBracket == -1)
        {
            tag = part;
        }
        else if (dexStartSquareBracket == -1 || dexEndSquareBracket == -1)
        {
            throw new Exception("Neukon\u010Den\u00E1 z\u00E1vorka v metod\u011B XPathPart.ctor");
        }
    }
}