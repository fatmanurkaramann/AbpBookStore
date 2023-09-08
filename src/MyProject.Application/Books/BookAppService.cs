using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using MyProject.Books.Dto;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Books
{
    public class BookAppService : AsyncCrudAppService<Book, BookDto, int, PagedBookResultRequestDto, CreateBookDto,BookDto>
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
    }
}
