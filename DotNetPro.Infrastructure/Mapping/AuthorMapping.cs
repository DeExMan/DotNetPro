using AutoMapper;
using DotNetPro.Core.Entities;
using DotNetPro.Infrastructure.Contract.Author;

namespace DotNetPro.Infrastructure.Mapping
{
    public class AuthorMapping : Profile
    {
        public AuthorMapping()
        {
            CreateMap<Author, AuthorDto>();
            CreateMap<Author, AuthorShortDto>();
            CreateMap<AuthorCreateDto, Author>();
            CreateMap<AuthorUpdateDto, Author>();
        }
    }
}
