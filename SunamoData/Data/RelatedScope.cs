namespace SunamoData.Data;

/// <summary>
///     EN: null is neutral (if has before and after same state, is considered as this state)
///     CZ: null is neutral(if has before and after same state, is considered as this state)
/// </summary>
public class RelatedScope
{
    private readonly bool?[] _states;

    /// <summary>
    /// Initializes a new instance of the <see cref="RelatedScope"/> class with the specified array size.
    /// </summary>
    /// <param name="arraySize">The size of the internal state array.</param>
    public RelatedScope(int arraySize)
    {
        _states = new bool?[arraySize];
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RelatedScope"/> class with the specified states.
    /// </summary>
    /// <param name="states">The initial states array.</param>
    public RelatedScope(bool?[] states)
    {
        _states = states;
    }

    /// <summary>
    ///     Is used for deleting regions blocks. All lines between must dont exists or be empty
    /// </summary>
    /// <param name="startIndexes">The list of start indexes to check.</param>
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
    /// Returns ranges where all lines between have a specific state. Was used for deleting comments.
    /// </summary>
    /// <param name="defaultValue">The default state value to start with.</param>
    /// <returns>A list of ranges matching the criteria.</returns>
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