namespace KPIapplication.Models
{
    public class PageQueryParametr
    {
        public PaginationParam? Page { get; set; }
    }

    public class PaginationParam
    {
        public int Size { get; set; } = 10;
        public int Index { get; set; } = 1;
    }
}
