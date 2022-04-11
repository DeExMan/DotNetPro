namespace DotNetPro.Infrastructure.Contract.Book
{
    public class BookUpdateDto
    {
        public string Name { get; set; }
        public long AuthorId { get; set; }
        public long GenreId { get; set; }
        public long LibraryId { get; set; }
    }
}
