using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public interface IBookManager:IDomainService
    {
        Task<Book> CreateAsync(Book entity);
    }
}
