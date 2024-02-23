using CLRL.Domain.Abstractions;
using CLRL.Domain.Users;

namespace CLRL.Domain.Books;

public sealed class Book : Entity
{
    public Book(
        Guid id,
        Title title,
        FirstName firstName,
        LastName lastName,
        TotalCopies totalCopies,
        UsedCopies usedCopies,
        BookType type,
        ISBN isbn,
        Category category)
        : base(id)
    {
        Title = title;
        FirstName = firstName;
        LastName = lastName;
        TotalCopies = totalCopies;
        UsedCopies = usedCopies;
        Type = type;
        ISBN = isbn;
        Category = category;
    }

    private Book()
    {
    }

    public Guid Id { get; private set; }

    public Title Title { get; private set; }

    public FirstName FirstName { get; private set; }

    public LastName LastName { get; private set; }

    public TotalCopies TotalCopies { get; private set; }

    public UsedCopies UsedCopies { get; private set; }

    public BookType Type { get; private set; }

    public ISBN ISBN { get; private set; }

    public Category Category { get; internal set; }

}
