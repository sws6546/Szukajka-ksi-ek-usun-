namespace SystemBiblioteczny;

public class Catalog
{
    public List<Book> Books { get; set; }
    public Catalog()
    {
        this.Books = new List<Book>() {
            new Book("0", "Pan Tadeusz", "Adam Mickiewicz"),
            new Book("1", "Wiedźmin: Ostatnie życzenie", "Andrzej Sapkowski"),
            new Book("2", "Wiedźmin: Miecz Przeznaczenia", "Andrzej Sapkowski"),
            new Book("3", "Wiedźmin: Pani Jeziora", "Andrzej Sapkowski"),
        };
    }

    public SearchResult Search(SearchQuery searchQuery)
    {
        List<Book> toReturn = new List<Book>();
        if (searchQuery.SearchCriteria == "id")
        {
            foreach (Book book in this.Books)
            {
                if (book.Id == searchQuery.Query)
                {
                    toReturn.Add(book);
                }
            }
        }
        if (searchQuery.SearchCriteria == "title")
        {
            foreach (Book book in this.Books)
            {
                if (book.Title == searchQuery.Query)
                {
                    toReturn.Add(book);
                }
            }
        }
        if (searchQuery.SearchCriteria == "author")
        {
            foreach (Book book in this.Books)
            {
                if (book.Author == searchQuery.Query)
                {
                    toReturn.Add(book);
                }
            }
        }
        return new SearchResult(toReturn);
    }
}