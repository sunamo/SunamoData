namespace SunamoData._sunamo;

public class SHSH
{
    //public static Func<string, Func<char, bool>, char[], string> RemoveAfterFirstFunc;

    public static string RemoveAfterFirstFunc(string v, Func<char, bool> isSpecial, params char[] canBe)
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

    //    public static Func<string, int, int, string> GetTextBetweenTwoChars;
    //    public static Func<string, object, string> RemoveAfterLast;
    //    public static Func<string, bool> IsNumber;
    //    public static Func<string, int, int, object, string> Substring;
    //    #region Cycle detected. SunamoData -> SunamoStringSplit 24.1.2.2 -> SunamoStringData 24.1.1.1 -> SunamoData (>= 23.12.24.1).
    //    public static Func<string, char[], List<string>> SplitChar;
    //    public static Func<string, string[], List<int>> SplitToIntList;
    //    #endregion
}
