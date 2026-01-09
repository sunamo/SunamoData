// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Parses pipe-separated string content into a string and an integer.
/// </summary>
public class StringInt : Parsing<string, int>
{
    /// <summary>
    /// Parses the content by splitting on the pipe character and converting the second part to an integer.
    /// </summary>
    /// <param name="content">The pipe-separated content to parse (format: "string|integer").</param>
    public override void Parse(string content)
    {
        if (content.Contains("|"))
        {
            var parts = SHSplit.Split(content, "|");
            FirstValue = parts[0];
            SecondValue = int.Parse(parts[1]);
        }
    }
}