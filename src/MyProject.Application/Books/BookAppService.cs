using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using AutoMapper;
using MyProject.Authorization.Users;
using MyProject.Books.Dto;
using MyProject.Models;
using MyProject.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Books
{
    public class BookAppService : AsyncCrudAppService<Book, BookDto, int, PagedBookResultRequestDto, CreateBookDto, BookDto>, IBookAppService
    {
        private readonly IBookManager _bookManager;
        public BookAppService(IRepository<Book, int> repository, IBookManager bookManager) : base(repository)
        {
            _bookManager = bookManager;
        }


        public override async Task<BookDto> CreateAsync(CreateBookDto input)
        {
            var book = new Book
            {
                Name = input.Name,
                ISBN = input.ISBN,
                AuthorId = input.AuthorId,
                Price = input.Price,
                PageCount = input.PageCount,
                ImagePath = input.ImagePath,
                PublishDate = input.PublishDate,
                Description = input.Description,
                CategoryId = input.CategoryId
            };
            await _bookManager.CreateAsync(book);
            return MapToEntityDto(book);
        }
        public override async Task<BookDto> UpdateAsync(BookDto input)
        {
            var book = await _bookManager.GetByIdAsync(input.Id);
            ObjectMapper.Map(input, book);
            await _bookManager.Update(book);
            return MapToEntityDto(book);
        }


        protected override IQueryable<Book> CreateFilteredQuery(PagedBookResultRequestDto input)
        {
            var query = Repository.GetAllIncluding(x => x.Author, async => async.Category);

            if (!input.Keyword.IsNullOrWhiteSpace())
            {
                query = query.Where(x => x.Name.Contains(input.Keyword));
            }

            return query;
        }

    }
}
