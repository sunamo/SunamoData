namespace SunamoData._sunamo;

internal class SHSH
{
    //internal static Func<string, Func<char, bool>, char[], string> RemoveAfterFirstFunc;

    internal static string RemoveAfterFirstFunc(string v, Func<char, bool> isSpecial, params char[] canBe)
    {
        v = v.Trim();
        for (int i = 0; i < v.Length; i++)
        {
            if (isSpecial(v[i]))
            {
                if (canBe.Contains(v[i]))
                {
                    continue;
                }
                return v.Substring(0, i);
            }
        }
        return v;
    }

    //    internal static Func<string, int, int, string> GetTextBetweenTwoChars;
    //    internal static Func<string, object, string> RemoveAfterLast;
    //    internal static Func<string, bool> IsNumber;
    //    internal static Func<string, int, int, object, string> Substring;
    //    #region Cycle detected. SunamoData -> SunamoStringSplit 24.1.2.2 -> SunamoStringData 24.1.1.1 -> SunamoData (>= 23.12.24.1).
    //    internal static Func<string, char[], List<string>> SplitChar;
    //    internal static Func<string, string[], List<int>> SplitToIntList;
    //    #endregion
}
