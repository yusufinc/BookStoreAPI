using Microsoft.AspNetCore.Mvc;
using BookstoreAPI.Models;
using BookstoreAPI.Data;

namespace BookstoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly BookstoreContext _context;

        public OrderController(BookstoreContext context)
        {
            _context = context;
        }

        // POST: api/Order
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            var book = await _context.Books.FindAsync(order.BookId);
            if (book == null)
            {
                return NotFound("Book not found.");
            }

            if (book.StockQuantity < order.Quantity)
            {
                return BadRequest("Insufficient stock.");
            }

            order.TotalPrice = book.Price * order.Quantity;
            _context.Orders.Add(order);
            book.StockQuantity -= order.Quantity; // Stok güncelleme
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        }

        // GET: api/Order/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/Order/5/status
        [HttpPut("{id}/status")]
        public async Task<IActionResult> PutOrderStatus(int id, OrderStatus status)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            order.Status = status;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
