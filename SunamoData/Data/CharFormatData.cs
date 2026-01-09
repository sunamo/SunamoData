// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Specifies how the input text must be formatted.
/// </summary>
public class CharFormatData
{
    /// <summary>
    /// Gets or sets the range specifying minimum and maximum length.
    /// </summary>
    public FromTo FromTo { get; set; } = new();

    /// <summary>
    /// Gets or sets the array of characters that are allowed.
    /// May have no elements, then the character can be arbitrary.
    /// </summary>
    public char[] MustBe { get; set; } = Array.Empty<char>();

    /// <summary>
    /// Gets or sets whether characters must be uppercase.
    /// Null = no matter. Most suitable is the Windows.UI.Text.LetterCase enum.
    /// </summary>
    public bool? IsUpper { get; set; } = false;

    /// <summary>
    /// Initializes a new instance of the <see cref="CharFormatData"/> class.
    /// </summary>
    /// <param name="isUpper">Whether characters must be uppercase (null = no matter).</param>
    /// <param name="mustBe">Array of allowed characters.</param>
    public CharFormatData(bool? isUpper, char[] mustBe)
    {
        IsUpper = isUpper;
        MustBe = mustBe;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CharFormatData"/> class.
    /// </summary>
    public CharFormatData()
    {
    }

    /// <summary>
    /// Creates a CharFormatData instance that accepts only numeric characters.
    /// </summary>
    /// <param name="requiredLength">The required length range.</param>
    /// <returns>A CharFormatData configured for numbers only.</returns>
    public static CharFormatData GetOnlyNumbers(FromTo requiredLength)
    {
        LetterAndDigitCharService letterAndDigitChar = new();

        var data = new CharFormatData();
        data.FromTo = requiredLength;
        data.MustBe = letterAndDigitChar.NumericChars.ToArray();
        return data;
    }

    /// <summary>
    /// Creates a CharFormatData instance with specified parameters.
    /// </summary>
    /// <param name="isUpper">Whether characters must be uppercase (null = no matter).</param>
    /// <param name="fromTo">The required length range.</param>
    /// <param name="mustBe">Array of allowed characters.</param>
    /// <returns>A configured CharFormatData instance.</returns>
    public static CharFormatData Get(bool? isUpper, FromTo fromTo, params char[] mustBe)
    {
        var data = new CharFormatData(isUpper, mustBe);
        data.FromTo = fromTo;
        return data;
    }

    /// <summary>
    /// Contains template CharFormatData configurations for common scenarios.
    /// </summary>
    public static class Templates
    {
        private static char NotNumberChar = (char)9;

        /// <summary>
        /// Template for a single dash character.
        /// </summary>
        public static CharFormatData Dash = Get(null, new FromTo(1, 1), '-');

        /// <summary>
        /// Template for a single non-number character.
        /// </summary>
        public static CharFormatData NotNumber = Get(null, new FromTo(1, 1), NotNumberChar);

        /// <summary>
        /// Template for one or two digit numbers.
        /// When doesn't contain fixed, is from 0 to number.
        /// </summary>
        public static CharFormatData TwoLetterNumber;

        /// <summary>
        /// Template for any characters with any length.
        /// </summary>
        public static CharFormatData Any;

        static Templates()
        {
            var requiredLength = new FromTo(1, 2);
            TwoLetterNumber = GetOnlyNumbers(requiredLength);
            Any = Get(null, new FromTo(0, int.MaxValue));
        }
    }
}