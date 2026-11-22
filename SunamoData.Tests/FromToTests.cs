using SunamoData.Data;

namespace SunamoData.Tests;

/// <summary>
/// Tests for parsing and formatting of FromTo.
/// </summary>
public class FromToTests
{
    /// <summary>
    /// Tests that a single time without end does not throw and has no data.
    /// </summary>
    [Fact]
    public void ParseSingleValueTest()
    {
        var fromTo = new FromTo();
        fromTo.Parse("18:30");
        Assert.Equal(18 * 3600 + 30 * 60, fromTo.FromLong);
        Assert.False(fromTo.IsFilledWithData());
    }

    /// <summary>
    /// Tests that a range round-trips through Parse and ToString.
    /// </summary>
    [Fact]
    public void ParseAndToStringRangeTest()
    {
        var fromTo = new FromTo();
        fromTo.Parse("9:05-24");
        Assert.True(fromTo.IsFilledWithData());
        Assert.Equal("9:05-23:59", fromTo.ToString());
    }

    /// <summary>
    /// Tests that text which is not a time does not throw and gives no data.
    /// </summary>
    [Fact]
    public void ParseGarbageTest()
    {
        var fromTo = new FromTo();
        fromTo.Parse("abc");
        Assert.False(fromTo.IsFilledWithData());
        fromTo.Parse("x:y-z");
        Assert.False(fromTo.IsFilledWithData());
    }
}
