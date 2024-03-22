namespace Mission11_Williams.Models.ViewModels
{
    public class BooksListViewModel
    {
        public IQueryable<Book> Books { get; set;}
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
