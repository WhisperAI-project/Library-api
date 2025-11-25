using System.Collections.Generic;

namespace LibraryAPI.Entities
{
    public class Library
    {
        public List<Book> Books { get; set; } = new();
        public List<User> Users { get; set; } = new();
        public List<Loan> Loans { get; set; } = new();
    }
}
