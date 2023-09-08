using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Category:Entity<int>
    {
        public string CategoryName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
