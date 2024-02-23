using CLRL.Domain.Abstractions;

namespace CLRL.Domain.Books;

public static class BookErrors
{
    public static readonly Error NotFound = new(
        "Book.NotFound",
        "The book with the specified identifier was not found");
}
