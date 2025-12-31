namespace SunamoData.Data;

/// <summary>
///     EN: Specifies how the input text must be formatted
///     CZ: Udává jak musí být vstupní text zformátovaný
/// </summary>
public class CharFormatData
{
    public FromTo FromTo;

    /// <summary>
    ///     EN: May have no elements, then the character can be arbitrary
    ///     CZ: Nemusí mít žádný prvek, pak může být znak libovolný
    /// </summary>
    public char[] MustBe;

    /// <summary>
    ///     EN: Null = no matter. Most suitable is the Windows.UI.Text.LetterCase enum
    ///     CZ: Null = no matter. Nejvhodnější je zde výčet Windows.UI.Text.LetterCase
    /// </summary>
    public bool? IsUpper = false;

    public CharFormatData(bool? isUpper, char[] mustBe)
    {
        IsUpper = isUpper;
        MustBe = mustBe;
    }

    public CharFormatData()
    {
    }

    public static CharFormatData GetOnlyNumbers(FromTo requiredLength)
    {
        LetterAndDigitCharService letterAndDigitChar = new();

        var data = new CharFormatData();
        data.FromTo = requiredLength;
        data.MustBe = letterAndDigitChar.NumericChars.ToArray();
        return data;
    }

    /// <summary>
    ///     EN: A1 Null = no matter
    ///     CZ: A1 Null = no matter
    /// </summary>
    public static CharFormatData Get(bool? isUpper, FromTo fromTo, params char[] mustBe)
    {
        var data = new CharFormatData(isUpper, mustBe);
        data.FromTo = fromTo;
        return data;
    }

    public static class Templates
    {
        static char NotNumberChar = (char)9;
        public static CharFormatData Dash = Get(null, new FromTo(1, 1), '-');
        public static CharFormatData NotNumber = Get(null, new FromTo(1, 1), NotNumberChar);

        /// <summary>
        ///     EN: When doesn't contain fixed, is from 0 to number
        ///     CZ: When doesn't contains fixed, is from 0 to number
        /// </summary>
        public static CharFormatData TwoLetterNumber;

        public static CharFormatData Any;

        static Templates()
        {
            var requiredLength = new FromTo(1, 2);
            TwoLetterNumber = GetOnlyNumbers(requiredLength);
            Any = Get(null, new FromTo(0, int.MaxValue));
        }
    }
}