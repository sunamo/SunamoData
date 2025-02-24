namespace SunamoData.Data;
public class ABC : List<AB> //, IList<AB>
{
    public static ABC Empty = new();

    public ABC()
    {
    }

    public ABC(int capacity) : base(capacity)
    {
        for (var i = 0; i < capacity; i++) Add(null);
    }

    public ABC(params object[] setsNameValue)
    {
        if (setsNameValue.Length == 0) return;
        var o = setsNameValue[0];
        var t = o.GetType();
        var t2 = t;
        if (o is IList)
        {
            var s = o as IList;
            var o2 = s.Count != 0 ? s[0] : null;
            t2 = o2.GetType();
        }

        //var t2 = setsNameValue[0][0].GetType();
        if (t2 == typeof(AB))
        {
            //var abc = null;
            //if (true)
            //{
            //}
            for (var i = 0; i < setsNameValue.Length; i++)
            {
                var snv = setsNameValue[i];
                t2 = snv.GetType();
                if (t2 == AB.type)
                {
                    Add((AB)snv);
                }
                else
                {
                    var ie = (IList)snv;
                    foreach (var item in ie)
                    {
                        var ab = (AB)item;
                        Add(ab);
                    }
                }
            }
        }
        else if (t == typeof(ABC))
        {
            var abc = (ABC)o;
            AddRange(abc);
        }
        else
        {
            // Dont use like idiot TwoDimensionParamsIntoOne where is not needed - just iterate. Must more use radio and less blindness
            //var setsNameValue = CA.TwoDimensionParamsIntoOne(setsNameValue2);
            for (var i = 0; i < setsNameValue.Length; i++) Add(AB.Get(setsNameValue[i].ToString(), setsNameValue[++i]));
        }
    }

    public ABC(params AB[] abc)
    {
        // TODO: Complete member initialization
        AddRange(abc);
    }

    public int Length => Count;

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var item in this) sb.Append(item + ",");
        return sb.ToString();
    }

    /// <summary>
    ///     Must be [] due to SQL viz
    ///     https://stackoverflow.com/questions/9149919/no-mapping-exists-from-object-type-system-collections-generic-list-when-executin
    /// </summary>
    public object[] OnlyBs()
    {
        return OnlyBsList().ToArray();
    }

    public List<object> OnlyBsList()
    {
        var o = new List<object>(Count);
        for (var i = 0; i < Count; i++) o.Add(this[i].B);
        return o;
    }

    public List<string> OnlyAs()
    {
        var o = new List<string>(Count);
        //CA.InitFillWith(o, Count);
        for (var i = 0; i < Count; i++) o[i] = this[i].A;
        return o;
    }

    public static List<object> OnlyBs(List<AB> arr)
    {
        return arr.Select(d => d.B).ToList();
    }
}