using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetPro.Core.Entities.Abstractions;

namespace DotNetPro.Core.Entities
{
    public class Book : Entity
    {
        public string Name { get; set; }

        public long AuthorId { get; set; }
        public Author Author { get; set; }

        public long GenreId { get; set; }
        public Genre Genre { get; set; }

        public long LibraryId { get; set; }
        public Library Library { get; set; }
    }
}
