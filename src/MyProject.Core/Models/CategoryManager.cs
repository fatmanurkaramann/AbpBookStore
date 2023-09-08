using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class CategoryManager : DomainService, ICategoryManager
    {
        private readonly IRepository<Category, int> _categoryRepository;

        public CategoryManager(IRepository<Category, int> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Category> Create(Category category)
        {
           return await _categoryRepository.InsertAsync(category);
        }
    }
}
