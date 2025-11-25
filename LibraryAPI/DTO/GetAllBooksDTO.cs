namespace LibraryAPI.DTO
{
    public class GetAllBooksDTO
    {
        public string Title { get; set; } = string.Empty;
        public bool IsAvailable { get; set; } = true;
    }
}
