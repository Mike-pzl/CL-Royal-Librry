using CLRL.Application.Books.SearchBooks;
using CLRL.Domain.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CLRL.API.Controllers.Books;

[Authorize]
[ApiController]
[Route("api/books")]
public class BookController(ISender sender) : ControllerBase
{
    private readonly ISender _sender = sender;

    [HttpGet]
    public async Task<IActionResult> SearchBooks(string searchValue, string searchType, CancellationToken cancellationToken)
    {
        var query = new SearchBooksQuery(searchValue, searchType);

        Result<IReadOnlyList<BookResponse>> result = await _sender.Send(query, cancellationToken);

        return Ok(result.Value);
    }
}
