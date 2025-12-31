namespace SunamoData.Data;

/// <summary>
///     Alternatives: FormatOfString - allow as many as is chars in every match
///     can check whether on position is expected char (letter, digit, etc.) but then not allow variable lenght of parsed
/// </summary>
public class TextFormatData : List<CharFormatData>
{
    /// <summary>
    ///     Přesná požadovaná délka, nesmí být ani menší, ani větší
    ///     Pokud je -1, text může mít jakoukoliv délku
    /// </summary>
    public int RequiredLength = -1;

    public bool TrimBefore;

    /// <summary>
    ///     Zadej do A2 -1 pokud text může mít jakoukoliv délku
    /// </summary>
    /// <param name="trimBefore"></param>
    /// <param name="requiredLength"></param>
    /// <param name="formatDataItems"></param>
    public TextFormatData(bool trimBefore, int requiredLength, params CharFormatData[] formatDataItems)
    {
        this.TrimBefore = trimBefore;
        this.RequiredLength = requiredLength;
        AddRange(formatDataItems);
    }

    public static class Templates
    {
    }
}