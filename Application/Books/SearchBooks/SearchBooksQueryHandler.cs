using CLRL.Application.Abstractions.Data;
using CLRL.Application.Abstractions.Messaging;
using CLRL.Domain.Abstractions;
using Dapper;
using System.Data;

namespace CLRL.Application.Books.SearchBooks;

internal sealed class SearchBooksQueryHandler
    : IQueryHandler<SearchBooksQuery, IReadOnlyList<BookResponse>>
{

    private readonly ISqlConnectionFactory _sqlConnectionFactory;

    public SearchBooksQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
        _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result<IReadOnlyList<BookResponse>>> Handle(SearchBooksQuery request, CancellationToken cancellationToken)
    {

        using IDbConnection connection = _sqlConnectionFactory.CreateConnection();

        const string sql = """
            SELECT
                a.id AS Id,
                a.name AS Name,
                a.description AS Description,
                a.price_amount AS Price,
                a.price_currency AS Currency,
                a.address_country AS Country,
                a.address_state AS State,
                a.address_zip_code AS ZipCode,
                a.address_city AS City,
                a.address_street AS Street
            FROM apartments AS a
            WHERE NOT EXISTS
            (
                SELECT 1
                FROM bookings AS b
                WHERE
                    b.apartment_id = a.id AND
                    b.duration_start <= @EndDate AND
                    b.duration_end >= @StartDate AND
                    b.status = ANY(@ActiveBookingStatuses)
            )
            """;

        IEnumerable<BookResponse> books = await connection
            .QueryAsync<BookResponse>(sql);

        return books.ToList();
    }
}
