namespace SunamoData.Data;

/// <summary>
/// Represents a parsed XPath expression part with tag and optional attribute.
/// </summary>
public class XPathPart
{
    /// <summary>
    /// Gets or sets the attribute name.
    /// </summary>
    public string AttributeName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the attribute value.
    /// </summary>
    public string AttributeValue { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the tag name.
    /// </summary>
    public string Tag { get; set; } = string.Empty;

    /// <summary>
    /// Initializes a new instance of the <see cref="XPathPart"/> class by parsing an XPath expression.
    /// </summary>
    /// <param name="xpathExpression">The XPath expression to parse.</param>
    /// <exception cref="Exception">Thrown when brackets are not properly closed.</exception>
    public XPathPart(string xpathExpression)
    {
        var closingBracketIndex = xpathExpression.IndexOf(']');
        var openingBracketIndex = xpathExpression.IndexOf('[');
        if (openingBracketIndex != -1 && closingBracketIndex != -1)
        {
            Tag = xpathExpression.Substring(0, openingBracketIndex);
            var attr = xpathExpression.Substring(openingBracketIndex + 1, closingBracketIndex - openingBracketIndex - 1);
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
        else if (openingBracketIndex == -1 && closingBracketIndex == -1)
        {
            Tag = xpathExpression;
        }
        else if (openingBracketIndex == -1 || closingBracketIndex == -1)
        {
            throw new Exception("Unclosed bracket in XPathPart constructor");
        }
    }
}