namespace SunamoData._sunamo;

internal class SHSplit
{
    internal static List<string> Split(string p, params string[] newLine)
    {
        return p.Split(newLine, StringSplitOptions.RemoveEmptyEntries).ToList();
    }


    internal static List<string> SplitChar(string parametry, params char[] deli)
    {
        return Split(StringSplitOptions.RemoveEmptyEntries, parametry,
            deli.ToList().ConvertAll(d => d.ToString()).ConvertAll(d => d.ToString()).ToArray());
    }

    internal static List<string> Split(StringSplitOptions stringSplitOptions, string text, params string[] deli)
    {
        if (deli == null || deli.Count() == 0) throw new Exception("NoDelimiterDetermined");
        //var ie = CA.OneElementCollectionToMulti(deli);
        //var deli3 = new List<string>IEnumerable2(ie);
        var result = text.Split(deli, stringSplitOptions).ToList();
        CA.Trim(result);
        if (stringSplitOptions == StringSplitOptions.RemoveEmptyEntries)
            result = result.Where(d => d.Trim() != string.Empty).ToList();

        return result;
    }
}