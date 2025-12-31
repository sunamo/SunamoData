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
        var firstElement = setsNameValue[0];
        var elementType = firstElement.GetType();
        var actualType = elementType;
        if (firstElement is IList)
        {
            var list = firstElement as IList;
            var firstListElement = list.Count != 0 ? list[0] : null;
            actualType = firstListElement.GetType();
        }

        //var actualType = setsNameValue[0][0].GetType();
        if (actualType == typeof(AB))
        {
            //var collection = null;
            //if (true)
            //{
            //}
            for (var i = 0; i < setsNameValue.Length; i++)
            {
                var currentElement = setsNameValue[i];
                actualType = currentElement.GetType();
                if (actualType == AB.Type)
                {
                    Add((AB)currentElement);
                }
                else
                {
                    var enumerable = (IList)currentElement;
                    foreach (var item in enumerable)
                    {
                        var abElement = (AB)item;
                        Add(abElement);
                    }
                }
            }
        }
        else if (elementType == typeof(ABC))
        {
            var collection = (ABC)firstElement;
            AddRange(collection);
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
        var stringBuilder = new StringBuilder();
        foreach (var item in this) stringBuilder.Append(item + ",");
        return stringBuilder.ToString();
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
        var result = new List<object>(Count);
        for (var i = 0; i < Count; i++) result.Add(this[i].Value);
        return result;
    }

    public List<string> OnlyAs()
    {
        var result = new List<string>(Count);
        //CA.InitFillWith(result, Count);
        for (var i = 0; i < Count; i++) result[i] = this[i].Key;
        return result;
    }

    public static List<object> OnlyBs(List<AB> list)
    {
        return list.Select(element => element.Value).ToList();
    }
}