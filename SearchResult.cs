namespace SystemBiblioteczny;

public class SearchResult
{
    public List<Book> Books { get; set; }
    public SearchResult(List<Book> books)
    {
        this.Books = books;
    }
}