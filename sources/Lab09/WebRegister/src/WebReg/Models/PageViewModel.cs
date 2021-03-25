namespace WebReg.Models
{
    public class PageViewModel
    {
        public int PageSize => 10;
        public int PagerSize => 5;
        public int? PageNumber { get; set; }
        public int TotalPages { get; set; }
        public int? PageIndex { get; set; }
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }
    }
}
