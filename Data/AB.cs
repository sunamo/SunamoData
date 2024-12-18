namespace SunamoData.Data;

public class AB
{
    public static Type type = typeof(AB);
    public string A;
    public object B;

    public AB(string a, object b)
    {
        A = a;
        B = b;
    }

    public static AB Get(Type a, object b)
    {
        return new AB(a.FullName, b);
    }

    /// <param name="a"></param>
    /// <param name="b"></param>
    public static AB Get(string a, object b)
    {
        return new AB(a, b);
    }

    public override string ToString()
    {
        return A + ":" + B;
    }
}