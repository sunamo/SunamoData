namespace SunamoData.Data;

/// <summary>
///     Udává jak musí být vstupní text zformátovaný
/// </summary>
public class CharFormatData
{
    public FromTo fromTo;

    /// <summary>
    ///     Nemusí mít žádný prvek, pak může být znak libovolný
    /// </summary>
    public char[] mustBe;

    /// <summary>
    ///     Null = no matter
    ///     Nejvhodnější je zde výčet Windows.UI.Text.LetterCase
    /// </summary>
    public bool? upper = false;

    public CharFormatData(bool? upper, char[] mustBe)
    {
        this.upper = upper;
        this.mustBe = mustBe;
    }

    public CharFormatData()
    {
    }

    public static CharFormatData GetOnlyNumbers(FromTo requiredLength)
    {
        var data = new CharFormatData();
        data.fromTo = requiredLength;
        data.mustBe = AllChars.numericChars.ToArray();
        return data;
    }

    /// <summary>
    ///     A1 Null = no matter
    /// </summary>
    /// <param name="upper"></param>
    /// <param name="fromTo"></param>
    /// <param name="mustBe"></param>
    public static CharFormatData Get(bool? upper, FromTo fromTo, params char[] mustBe)
    {
        var data = new CharFormatData(upper, mustBe);
        data.fromTo = fromTo;
        return data;
    }

    public static class Templates
    {
        public static CharFormatData dash = Get(null, new FromTo(1, 1), AllChars.dash);
        public static CharFormatData notNumber = Get(null, new FromTo(1, 1), AllChars.notNumber);

        /// <summary>
        ///     When doesn't contains fixed, is from 0 to number
        /// </summary>
        public static CharFormatData twoLetterNumber;

        public static CharFormatData Any;

        static Templates()
        {
            var requiredLength = new FromTo(1, 2);
            twoLetterNumber = GetOnlyNumbers(requiredLength);
            Any = Get(null, new FromTo(0, int.MaxValue));
        }
    }
}