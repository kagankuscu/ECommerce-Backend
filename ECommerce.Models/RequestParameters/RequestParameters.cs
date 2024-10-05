namespace ECommerce.Models.RequestParameters;

public class RequestParameters
{
    const int maxPageSize = 52;

    public int PageNumber { get; set;}

    private int _pageSize;
    public int PublicSize
    {
        get { return _pageSize; }
        set { _pageSize = value > maxPageSize ? maxPageSize : value;}
    }

    public string? OrderBy { get; set;}
}
