using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetPro.Core.Entities.Abstractions;

namespace DotNetPro.Core.Entities
{
    public class Library : Entity
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
