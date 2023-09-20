using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public interface IAuthorManager
    {
        Task<Author> GetById(int id);
        Task<Author> CreateAsync(Author author);
        Task<Author> UpdateAsync(Author author);
    }
}
