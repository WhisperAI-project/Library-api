using System;

namespace LibraryAPI.Entities
{
    public class Loan
    {
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime BorrowedAt { get; set; }
    }
}
