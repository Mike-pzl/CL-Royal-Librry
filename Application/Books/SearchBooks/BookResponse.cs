namespace CLRL.Application.Books.SearchBooks;

public sealed class BookResponse
{

    public string Title { get; private set; }

    public string Author { get; private set; }

    public int TotalCopies { get; private set; }

    public int UsedCopies { get; private set; }

    public string Type { get; private set; }

    public string ISBN { get; private set; }

    public string Category { get; internal set; }
}
