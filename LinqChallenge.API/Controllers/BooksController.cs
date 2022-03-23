using LinqChallenge.API.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LinqChallenge.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly BookStoreDbContext _context;

    public BooksController(BookStoreDbContext context)
    {
        _context = context;
    }

    [HttpGet("")]
    public async Task<IActionResult> GetBooks()
    {
        var authors = await _context.Authors.ToListAsync();
        return Ok(authors);
    }
}
