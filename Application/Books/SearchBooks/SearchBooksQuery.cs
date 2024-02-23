using CLRL.Application.Abstractions.Messaging;

namespace CLRL.Application.Books.SearchBooks;

public sealed record SearchBooksQuery(
    string SearchValue,
    string SearchType) : IQuery<IReadOnlyList<BookResponse>>;
