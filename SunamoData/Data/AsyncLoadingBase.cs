namespace SunamoData.Data;

public class AsyncLoadingBase<T, TProgressBar>
{
    public TProgressBar ProgressBar;
    public long ProcessedCount = 0;
    public Action<T> StatusAfterLoad;
}