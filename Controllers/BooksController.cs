using Microsoft.AspNetCore.Mvc;
using BookApi.Models;

namespace BookApi.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase {
        private static readonly List<Book> _books = new() {
            new Book { Id = 1, Title = "C# Basics", Author = "Soeurng LIM", Price = 15.50m },
            new Book { Id = 2, Title = "ASP.NET API", Author = "Developer", Price = 25.00m }
        };

        [HttpGet]
        public IActionResult GetAllBooks() => Ok(_books);

        [HttpGet("{id}")]
        public IActionResult GetBookById(int id) {
            var book = _books.FirstOrDefault(b => b.Id == id);
            return book != null ? Ok(book) : NotFound(new { Message = "សៀវភៅរកមិនឃើញ" });
        }
    }
}