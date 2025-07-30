namespace SunamoData.Data;

public class PhotoFileNameConvention
{
    public uint? number = null;
    public string text = "";


    #region Constanty - začátek názvů souborů fotek které jsou ve konvenci písmeno/a + číslo - všechno musím kontrolovat také na malé

    public const string DSC = "DSC";
    public const string DSC_ = "DSC_";

    public const string DSCN = "DSCN";
    public const string YDXJ = "YDXJ";
    public const string P = "P";
    public const string DSC__ = "DSC ";

    #endregion
}