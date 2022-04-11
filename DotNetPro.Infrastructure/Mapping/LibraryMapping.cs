using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DotNetPro.Core.Entities;
using DotNetPro.Infrastructure.Contract.Library;

namespace DotNetPro.Infrastructure.Mapping
{
    public class LibraryMapping : Profile
    {
        public LibraryMapping()
        {
            CreateMap<Library, LibraryDto>();
            CreateMap<Library, LibraryShortDto>();
            CreateMap<LibraryCreateDto, Library>();
            CreateMap<LibraryUpdateDto, Library>();
        }
    }
}
