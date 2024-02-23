using CLRL.Domain.Books;

namespace CLRL.Infrastructure.Repositories;

internal sealed class BookRepository : Repository<Book>, IBookRepository
{
    public BookRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }
}
