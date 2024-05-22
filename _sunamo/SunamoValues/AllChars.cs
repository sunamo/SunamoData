namespace SunamoData;


internal class AllChars
{
    internal static List<char> vsZnakyWithoutSpecial;
    internal static List<char> vsZnaky = null;
    internal const char comma = ',';
    internal const char bs = '\\';
    internal const char dot = '.';
    internal const char la = '‘';
    internal const char ra = '’';
    internal const char st = '\0';
    internal const char euro = '€';
    static AllChars()
    {
        ConvertWhiteSpaceCodesToChars();
        notNumber = (char)whiteSpacesCodes[0];
        generalChars = new List<char>(new[] { notNumber });
        specialCharsAll = new List<char>(specialChars.Count + specialChars2.Count + specialCharsWhite.Count);
        specialCharsAll.AddRange(specialChars);
        specialCharsAll.AddRange(specialChars2);
        specialCharsAll.AddRange(specialCharsWhite);
        vsZnaky = new List<char>(AllChars.lowerChars.Count + AllChars.numericChars.Count + AllChars.specialChars.Count + AllChars.upperChars.Count);
        vsZnaky.AddRange(AllChars.lowerChars);
        vsZnaky.AddRange(AllChars.numericChars);
        vsZnaky.AddRange(AllChars.specialChars);
        vsZnaky.AddRange(AllChars.upperChars);
        vsZnakyWithoutSpecial = new List<char>(AllChars.lowerChars.Count + AllChars.numericChars.Count + AllChars.upperChars.Count);
        vsZnakyWithoutSpecial.AddRange(AllChars.lowerChars);
        vsZnakyWithoutSpecial.AddRange(AllChars.numericChars);
        vsZnakyWithoutSpecial.AddRange(AllChars.upperChars);
    }
    internal static readonly List<int> specialKeyCodes =
    new(new[] { 33, 64, 35, 36, 37, 94, 38, 42, 63, 95, 126 });
    internal static readonly List<char> specialCharsWhite = new(new[] { space });
    internal static readonly List<char> specialCharsNotEnigma = new(new[] { nbsp, space160, copy });
    /// <summary>
    ///     Used in enigma
    /// </summary>
    internal static readonly List<char> specialCharsAll;
    internal static readonly List<int> numericKeyCodes = new(new[] { 49, 50, 51, 52, 53, 54, 55, 56, 57, 48 });
    internal static readonly List<char> numericChars =
    new(new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' });
    internal static readonly List<int> lowerKeyCodes = new(new[]
    {
97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119,
120, 121, 122
});
    internal static readonly List<char> lowerChars = new(new[]
    {
'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
'w', 'x', 'y', 'z'
});
    internal static readonly List<int> upperKeyCodes = new(new[]
    { 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 });
    internal static readonly List<char> upperChars = new(new[]
    {
'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
'W', 'X', 'Y', 'Z'
});
    internal static readonly List<char> specialChars = new(new[]
    { excl, commat, num, dollar, percnt, Hat, amp, ast, quest, lowbar, tilda });
    private static readonly Type type = typeof(AllChars);
    // my extension
    internal static readonly List<char> generalChars;
    // IsWhiteSpace
    // , 55296 mi taky vrátila metoda IsWhiteSpace vrátila, ale při znovu vytvoření pomocí tohoto kódu to vyhazovalo výjimku
    /// <summary>
    ///     160 is space, is used for example in Uctenkovka
    /// </summary>
    internal static readonly List<int> whiteSpacesCodes = new(new[]
    {
9, 10, 11, 12, 13, 32, 133, 160, 5760, 6158, 8192, 8193, 8194, 8195, 8196, 8197, 8198, 8199, 8200, 8201, 8202,
8232, 8233, 8239, 8287, 12288
});
    internal static List<char> whiteSpacesChars;
    internal static char space160 = (char)160;
    internal static readonly char notNumber;
    /// <summary>
    ///     2020-07-4 added slash
    /// </summary>
    internal static readonly List<char> specialChars2 = new(new[]
    {
lq, rq, dash, la, ra,
comma, period, colon, apos, rpar, sol, lt, gt, lcub, rcub, lsqb, verbar, semi, plus, rsqb,
ndash, slash
});
    internal static Predicate<char> ReturnRightPredicate(char genericChar)
    {
        Predicate<char> predicate = null;
        if (genericChar == notNumber)
            predicate = char.IsNumber;
        else
            ThrowEx.NotImplementedCase(generalChars);
        return predicate;
    }
    internal static void ConvertWhiteSpaceCodesToChars()
    {
        AllStrings.whiteSpacesChars = new List<string>(whiteSpacesCodes.Count);
        whiteSpacesChars = new List<char>(whiteSpacesCodes.Count);
        foreach (var item in whiteSpacesCodes)
        {
            var s = char.ConvertFromUtf32(item);
            var ch = Convert.ToChar(s);
            whiteSpacesChars.Add(ch);
            AllStrings.whiteSpacesChars.Add(ch.ToString());
        }
    }
    #region from AllCharsConsts.cs
    ///// <summary>
    ///// char code 32
    ///// </summary>
    //internal const char space = ' ';
    ///// <summary>
    ///// Look similar as 32 space
    ///// </summary>
    //internal const char nbsp = (char)160;
    //#region Generated with SunamoFramework.HtmlEntitiesForNonDigitsOrLetterChars
    //internal const char dollar = '$';
    //internal const char Hat = '^';
    //internal const char ast = '*';
    //internal const char quest = '?';
    //internal const char tilda = '~';
    //internal const char comma = ',';
    //internal const char period = '.';
    //internal const char colon = ':';
    //internal const char excl = '!';
    //internal const char apos = '\'';
    //internal const char rpar = ')';
    //internal const char lpar = '(';
    //internal const char sol = '/';
    //internal const char lowbar = '_';
    //internal const char lt = '<';
    ///// <summary>
    ///// skip in specialChars2 - already as equal
    ///// </summary>
    //internal const char equals = '=';
    //internal const char gt = '>';
    //internal const char amp = '&';
    //internal const char lcub = '{';
    //internal const char rcub = '}';
    //internal const char lsqb = '[';
    //internal const char verbar = '|';
    //internal const char semi = ';';
    //internal const char commat = '@';
    //internal const char plus = '+';
    //internal const char rsqb = ']';
    //internal const char num = '#';
    //internal const char percnt = '%';
    //internal const char ndash = '–';
    //internal const char copy = '©';
    //#endregion
    //internal static readonly List<char> specialChars = new List<char>(new char[] { excl, commat, num, dollar, percnt, Hat, amp, ast, quest, lowbar, tilda });
    #endregion
    #region For easy copy from AllChars.cs
    // my extension
    /*
    equal->equals
    *
    * Ascii - 128 chars - 7B
    * ASCII + code page (e.g. ISO 8859-1) - 256 chars - 8B
    *
    * Unicode 11.0:
    * * Basic Multilingual Plane - 65536 letters - table 16*16, in every cell 256 letters, all others (SMP, SIP, TIP) are part of this
    * Supplementary Multilingual Plane (SMP) - Doplňková multilinguální rovina - 14000 chars -
    * Supplementary Ideographic Plane (SIP) - 53424 chars -
    * Tertiary Ideographic Plane (TIP) - 16672 chars
    * Supplementary Special-purpose Plane (SSP) - 368 chars
    * 15 PUA-A 65536
    * 16 PUA-B 65536
    *
    * =  overall 264256 letters
    *
    * Surrogates - replacement, by two surrogates is coded one letter above BMP (surrogate pair). Is in UTF16. Benefit is less space (some letters have two bytes, others 4B). In UTF32 is every char 4bytes.
    * char.IsSurrogatePair(low, right) - pair is formed by low and high
    * *
    */
    // IsControl
    //internal const List<int> controlKeyCodes =
    // IsDigit - IsNumber + superset atd.
    // IsHighSurrogate -
    // IsLower
    // IsLowSurrogate
    // IsNumber - 0..9
    // IsPunctuation
    // IsSeparatorw
    // IsSurrogate
    // IsSurrogatePair
    // IsSymbol
    // IsUpper
    #endregion
    #region For easy copy from AllCharsConsts.cs
    /// <summary>
    ///     char code 32
    /// </summary>
    internal const char space = ' ';
    /// <summary>
    ///     Look similar as 32 space
    /// </summary>
    internal const char nbsp = (char)160;
    #region Generated with SunamoFramework.HtmlEntitiesForNonDigitsOrLetterChars
    internal const char dollar = '$';
    internal const char Hat = '^';
    internal const char ast = '*';
    internal const char quest = '?';
    internal const char tilda = '~';
    internal const char period = '.';
    internal const char colon = ':';
    internal const char excl = '!';
    internal const char apos = '\'';
    internal const char rpar = ')';
    internal const char lpar = '(';
    internal const char sol = '/';
    internal const char lowbar = '_';
    internal const char lt = '<';
    /// <summary>
    ///     skip in specialChars2 - already as equal
    /// </summary>
    internal const char equals = '=';
    internal const char gt = '>';
    internal const char amp = '&';
    internal const char lcub = '{';
    internal const char rcub = '}';
    internal const char lsqb = '[';
    internal const char verbar = '|';
    internal const char semi = ';';
    internal const char commat = '@';
    internal const char plus = '+';
    internal const char rsqb = ']';
    internal const char num = '#';
    internal const char percnt = '%';
    internal const char ndash = '–';
    internal const char copy = '©';
    #endregion
    #endregion
    #region MyRegion
    internal const char lq = '“';
    internal const char rq = '”';
    #region Generic chars
    internal const char zero = '0';
    #endregion
    #region Names here must be the same as in Consts
    internal const char modulo = '%';
    internal const char dash = '-';
    #endregion
    internal const char tab = '\t';
    internal const char nl = '\n';
    internal const char cr = '\r';
    internal const char asterisk = '*';
    internal const char apostrophe = '\'';
    internal const char sc = ';';
    /// <summary>
    ///     quotation marks
    /// </summary>
    internal const char qm = '"';
    /// <summary>
    ///     Question
    /// </summary>
    internal const char q = '?';
    /// <summary>
    ///     Left bracket
    /// </summary>
    internal const char lb = '(';
    internal const char rb = ')';
    internal const char slash = '/';
    /// <summary>
    ///     backspace
    /// </summary>
    internal const char bs2 = '\b';
    #endregion
}