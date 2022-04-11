using System;

namespace DotNetPro.Infrastructure.Contract.Book
{
    public class BookDto
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EditedDate { get; set; }

        public string Name { get; set; }
        public long AuthorId { get; set; }
        public long GenreId { get; set; }
        public long LibraryId { get; set; }
    }
}
