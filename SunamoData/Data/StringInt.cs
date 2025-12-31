namespace SunamoData.Data;

/// <summary>
/// </summary>
public class StringInt : Parsing<string, int>
{
    /// <summary>
    ///     Serializuje na string a int A1
    /// </summary>
    /// <param name="content"></param>
    public override void ParsujM(string content)
    {
        if (content.Contains("|"))
        {
            var fd = SHSplit.Split(content, "|"); //SF.GetAllElementsLine(content, null);
            FirstValue = fd[0];
            SecondValue = int.Parse(fd[1]);
        }
    }
}