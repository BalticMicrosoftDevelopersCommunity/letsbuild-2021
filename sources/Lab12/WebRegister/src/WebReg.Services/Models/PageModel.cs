namespace WebReg.Services.Models
{
    public class PageModel
    {
        public int PageSize { get; set; } = 10;
        public int PagerSize { get; set; } = 5;
        public int PageNumber { get; set; } = 1;
        public int TotalPages { get; set; }
        public int PageIndex { get; set; } = 1;
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }
}
