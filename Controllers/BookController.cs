using Microsoft.AspNetCore.Mvc;
using BookstoreAPI.Models;  // Book ve Category modellerini kullanmak için
using Microsoft.EntityFrameworkCore;
using BookstoreAPI.Data;

namespace BookstoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookstoreContext _context;

        public BookController(BookstoreContext context)
        {
            _context = context;
        }

        // GET: api/Book
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Books.Include(b => b.Category).ToListAsync();
        }

        // GET: api/Book/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Books.Include(b => b.Category).FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // GET: api/Book/search?title={title}
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByTitle([FromQuery] string title)
        {
            var books = await _context.Books
                .Where(b => b.Title.Contains(title))
                .Include(b => b.Category)
                .ToListAsync();

            if (!books.Any())
            {
                return NotFound("No books found with the given title.");
            }

            return books;
        }

        // GET: api/Book/category/{categoryId}
        [HttpGet("category/{categoryId}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByCategory(int categoryId)
        {
            var books = await _context.Books
                .Where(b => b.CategoryId == categoryId)
                .Include(b => b.Category)
                .ToListAsync();

            if (!books.Any())
            {
                return NotFound("No books found for the given category.");
            }

            return books;
        }

        // POST: api/Book
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBook", new { id = book.Id }, book);
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Book/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
