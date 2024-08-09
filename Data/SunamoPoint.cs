namespace SunamoData.Data;

public class SunamoPoint
{
    public SunamoPoint()
    {
    }

    public SunamoPoint(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; set; }
    public double Y { get; set; }

    public void Parse(string input)
    {
        var d = input.Split(',');
        //ParserTwoValues.ParseDouble(AllStrings.comma, SHParts.RemoveAfterFirstFunc(input, char.IsLetter, new char[] { AllChars.comma }));
        X = double.Parse(d[0]);

        Y = double.Parse(d[1]);
    }

    public override string ToString()
    {
        //return ParserTwoValues.ToString(AllStrings.comma, X.ToString(), Y.ToString());
        return X + "," + Y;
    }
}