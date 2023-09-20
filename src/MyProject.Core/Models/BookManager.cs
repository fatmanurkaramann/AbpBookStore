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

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _bookRepository.GetAsync(id);
        }

        public async Task<Book> Update(Book entity)
        {
           return await _bookRepository.UpdateAsync(entity);
        }
        public List<Book> GetAll()
        {
            var book = _bookRepository.GetAllIncluding(b => b.Author, b => b.Category)
                       .ToList();
            return book;
        }
    }
}
