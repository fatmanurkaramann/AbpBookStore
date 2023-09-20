using Abp.Application.Services;
using Abp.Domain.Repositories;
using MyProject.Authorization.Roles;
using MyProject.Categories.Dto;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Categories
{
    public class CategoryAppService : AsyncCrudAppService<Category, CategoryDto, int, CategoryDto, CreateCategoryDto, CategoryDto>
    {
        private readonly ICategoryManager _categoryManager;
        public CategoryAppService(IRepository<Category, int> repository, ICategoryManager categoryManager) : base(repository)
        {
            _categoryManager = categoryManager;
        }

        public override async Task<CategoryDto> CreateAsync(CreateCategoryDto input)
        {
           
            var category = new Category
            {
                CategoryName = input.CategoryName
            };
            await _categoryManager.Create(category);
            return MapToEntityDto(category);
        }
        public override async Task<CategoryDto> UpdateAsync(CategoryDto input)
        {
            var category = await _categoryManager.GetByIdAsync(input.Id);
            ObjectMapper.Map(input, category);
            await _categoryManager.Update(category);
            return MapToEntityDto(category);

            
        }
    }
}
