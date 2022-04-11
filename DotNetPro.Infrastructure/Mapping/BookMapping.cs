using AutoMapper;
using DotNetPro.Core.Entities;
using DotNetPro.Infrastructure.Contract.Book;

namespace DotNetPro.Infrastructure.Mapping
{
    public class BookMapping : Profile
    {
        public BookMapping()
        {
            CreateMap<Book, BookDto>();
            CreateMap<Book, BookShortDto>();
            CreateMap<BookCreateDto, Book>();
            CreateMap<BookUpdateDto, Book>();
        }
    }
}
