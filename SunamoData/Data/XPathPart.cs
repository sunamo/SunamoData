namespace SunamoData.Data;

public class XPathPart
{
    private static Type Type = typeof(XPathPart);
    public string AttributeName;
    public string AttributeValue = "";
    public string Tag;
    public XPathPart(string xpathExpression)
    {
        var dexStartSquareBracket = xpathExpression.IndexOf(']');
        var dexEndSquareBracket = xpathExpression.IndexOf('[');
        if (dexStartSquareBracket != -1 && dexEndSquareBracket != -1)
        {
            Tag = xpathExpression.Substring(0, dexStartSquareBracket);
            var attr = xpathExpression.Substring(dexStartSquareBracket + 1, dexEndSquareBracket - 1);
            if (attr != "")
                if (attr[0] == '@')
                {
                    var nameValue = SHSplit.SplitChar(attr.Substring(1), '"', '\\', '=');
                    if (nameValue.Count == 2)
                        if (nameValue[0] != "")
                        {
                            AttributeName = nameValue[0];
                            AttributeValue = nameValue[1];
                        }
                }
        }
        else if (dexStartSquareBracket == -1 && dexEndSquareBracket == -1)
        {
            Tag = xpathExpression;
        }
        else if (dexStartSquareBracket == -1 || dexEndSquareBracket == -1)
        {
            throw new Exception("Neukon\u010Den\u00E1 z\u00E1vorka v metod\u011B XPathPart.ctor");
        }
    }
}