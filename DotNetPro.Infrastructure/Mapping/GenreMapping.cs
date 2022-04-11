using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DotNetPro.Core.Entities;
using DotNetPro.Infrastructure.Contract.Genre;

namespace DotNetPro.Infrastructure.Mapping
{
    public class GenreMapping : Profile
    {
        public GenreMapping()
        {
            CreateMap<Genre, GenreDto>();
            CreateMap<Genre, GenreShortDto>();
            CreateMap<GenreCreateDto, Genre>();
            CreateMap<GenreUpdateDto, Genre>();
        }
    }
}
