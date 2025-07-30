namespace SunamoData.Data;

public class AsyncLoadingBase<T, ProgressBar>
{
    public ProgressBar pb;
    public long processedCount = 0;
    public Action<T> statusAfterLoad;
}