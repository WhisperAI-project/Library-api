using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Entities;
using LibraryAPI.DTO;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet("GetAllBooks")]
        public IActionResult GetAllBooks()
        {
            // Logic to retrieve all books
            var books = new List<GetAllBooksDTO>
            {
                new GetAllBooksDTO { Title = "How to create microservices", IsAvailable = true },
                new GetAllBooksDTO { Title = "Learning API first", IsAvailable = false }

            };

            return Ok(books);
        }
    }
}
