using System;

namespace DotNetPro.Infrastructure.Contract.Library
{
    public class LibraryDto
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EditedDate { get; set; }
        public string Name { get; set; }
    }
}
