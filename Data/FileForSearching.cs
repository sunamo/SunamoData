namespace
#if SunamoShared
SunamoShared
#else
SunamoData
#endif
;
public class FileForSearching
{
    public bool surelyNo = false;
    public List<int> foundedLines = new List<int>();
    public List<string> linesLower = null;
    public List<string> lines = null;
    string path = null;
    public FileForSearching(string path)
    {
        this.path = path;
    }
    public
#if ASYNC
async Task
#else
void
#endif
        Init()
    {
        lines = (
#if ASYNC
await
#endif
File.ReadAllLinesAsync(path)).ToList();
        linesLower = new List<string>(lines.Count);
        foreach (var item in lines)
        {
            linesLower.Add(item.ToLower());
        }
    }
}