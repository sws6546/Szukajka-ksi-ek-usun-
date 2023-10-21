namespace SystemBiblioteczny;

public class Book
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public Book(string id, string title, string author)
    {
        this.Id = id;
        this.Title = title;
        this.Author = author;
    } 
}