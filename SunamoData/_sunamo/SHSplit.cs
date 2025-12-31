namespace SunamoData._sunamo;

internal class SHSplit
{
    internal static List<string> Split(string text, params string[] delimiters)
    {
        return text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
    }


    internal static List<string> SplitChar(string text, params char[] delimiters)
    {
        return Split(StringSplitOptions.RemoveEmptyEntries, text,
            delimiters.ToList().ConvertAll(character => character.ToString()).ToArray());
    }

    internal static List<string> Split(StringSplitOptions stringSplitOptions, string text, params string[] delimiters)
    {
        if (delimiters == null || delimiters.Count() == 0) throw new Exception("NoDelimiterDetermined");
        //var ie = CA.OneElementCollectionToMulti(deli);
        //var deli3 = new List<string>IEnumerable2(ie);
        var result = text.Split(delimiters, stringSplitOptions).ToList();
        CA.Trim(result);
        if (stringSplitOptions == StringSplitOptions.RemoveEmptyEntries)
            result = result.Where(part => part.Trim() != string.Empty).ToList();

        return result;
    }
}