using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Author:Entity<int>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<University> Universities { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
