namespace eCommerceProject.MvcWebUI.Models
{
    public class PagingInfo
    {
        public string BaseUrl { get; internal set; }
        public object Currentcategory { get; internal set; }
        public int CurrentPage { get; internal set; }
        public int TotalPageCount { get; internal set; }
    }
}