namespace CLRL.Domain.Books;

public interface IBookRepository
{
    Task<Book?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    //Task<Book?> GetByAuthor(string id, CancellationToken cancellationToken = default);
    //Task<Book?> GetByISBN(string id, CancellationToken cancellationToken = default);
}
