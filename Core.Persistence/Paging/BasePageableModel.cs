namespace Core.Persistence.Paging;

public abstract class BasePageableModel
{
    int Index { get; }
    int Size { get; }
    int Count { get; }
    int Pages { get; }
    bool HasPrevious { get; }
    bool HasNext { get; }
}
