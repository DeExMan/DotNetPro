namespace DotNetPro.Infrastructure.Contract.Book
{
    public class BookCreateDto
    {
        public string Name { get; set; }
        public long AuthorId { get; set; }
        public long GenreId { get; set; }
        public long LibraryId { get; set; }
    }
}
