using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class University:Entity<int>
    {
        public string UniversityName { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}
