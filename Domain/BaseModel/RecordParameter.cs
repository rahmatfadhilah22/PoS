namespace Domain.Models
{
    public class RecordsParameter
    {
        public string? Keyword { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? SortColumn { get; set; } = string.Empty;
        public string? Direction { get; set; } = "asc";

    }
}
