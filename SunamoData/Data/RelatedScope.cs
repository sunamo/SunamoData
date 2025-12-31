namespace SunamoData.Data;

/// <summary>
///     EN: null is neutral (if has before and after same state, is considered as this state)
///     CZ: null is neutral(if has before and after same state, is considered as this state)
/// </summary>
public class RelatedScope
{
    private readonly bool?[] _states;

    public RelatedScope(int arraySize)
    {
        _states = new bool?[arraySize];
    }

    public RelatedScope(bool?[] states)
    {
        _states = states;
    }

    /// <summary>
    ///     Is used for deleting regions blocks. All lines between must dont exists or be empty
    /// </summary>
    /// <param name="def"></param>
    /// <param name="b"></param>
    public List<FromTo> RangeFromStateSimple(List<int> startIndexes)
    {
        var foundedRanges = new List<FromTo>();

        var insideRegion = false;
        var fromTo = new FromTo();

        for (var i = 0; i < _states.Length; i++)
        {
            var builder = _states[i];
            if (builder.HasValue)
                if (builder.Value)
                {
                    if (insideRegion)
                    {
                        if (startIndexes.Contains(i))
                        {
                            fromTo.From = i;
                        }
                        else
                        {
                            insideRegion = false;
                            fromTo.To = i;
                            foundedRanges.Add(fromTo);
                        }
                    }
                    else
                    {
                        insideRegion = true;

                        fromTo = new FromTo();
                        fromTo.From = i;
                    }
                }
        }

        return foundedRanges;
    }

    /// <summary>
    ///     Was used for deleting comments. Returns serie only when is all lines between is comments
    /// </summary>
    /// <param name="def"></param>
    /// <param name="b"></param>
    public List<FromTo> RangeFromState(bool defaultValue)
    {
        var foundedRanges = new List<FromTo>();
        // true - is in code block. false - in non-code block
        var previous = defaultValue;
        var fromTo = new FromTo();
        fromTo.From = 0;

        for (var i = 0; i < _states.Length; i++)
        {
            var state = _states[i];
            // If line have some content
            if (state.HasValue)
            {
                // and it's code
                if (!state.Value)
                {
                    // ... and actually I'm in comment block
                    if (!previous)
                    {
                        fromTo.To = i - 1;
                        if (fromTo.From != fromTo.To) foundedRanges.Add(fromTo);
                        previous = true;
                    }
                }
                // its comment!
                else
                {
                    // I'm actually in non-code block
                    if (previous)
                    {
                        fromTo = new FromTo();
                        fromTo.From = i;
                        previous = false;
                    }
                }
            }
        }

        if (!previous)
        {
            fromTo.To = _states.Length - 1 - 1 + 1;
            if (fromTo.From != fromTo.To) foundedRanges.Add(fromTo);
        }

        return foundedRanges;
    }
}