namespace Mission11_Williams.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book>Books {get;}
    }
}
