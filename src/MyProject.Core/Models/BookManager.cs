using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class BookManager:DomainService,IBookManager
    {
        private readonly IRepository<Book, int> _bookRepository;

        public BookManager(IRepository<Book, int> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<Book> CreateAsync(Book entiity)
        {
            return await _bookRepository.InsertAsync(entiity);
        }
    }
}
