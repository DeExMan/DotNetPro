using System;

namespace DotNetPro.Infrastructure.Contract.Genre
{
    public class GenreDto
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EditedDate { get; set; }
        public string Name { get; set; }
    }
}
