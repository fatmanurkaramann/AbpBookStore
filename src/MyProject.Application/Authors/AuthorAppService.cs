using Abp.Application.Services;
using Abp.Domain.Repositories;
using MyProject.Authorization.Users;
using MyProject.Authors.Dto;
using MyProject.Categories.Dto;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Authors
{
    public class AuthorAppService : AsyncCrudAppService<Author, AuthorDto, int, AuthorDto, CreateAuthorDto, AuthorDto>
    {
        private readonly IAuthorManager _authorManager;
        private readonly IBookManager _bookManager;
        public AuthorAppService(IRepository<Author, int> repository, IAuthorManager authorManager, IBookManager bookManager) : base(repository)
        {
            _authorManager = authorManager;
            _bookManager = bookManager;
        }

        public override async Task<AuthorDto> CreateAsync(CreateAuthorDto input)
        { 

            var author = ObjectMapper.Map<Author>(input);
            var addedAuthor = await _authorManager.CreateAsync(author);
            await CurrentUnitOfWork.SaveChangesAsync();
            int authorId = addedAuthor.Id;
            var newAuthor = await _authorManager.GetById(authorId);
            var book = await _bookManager.GetByIdAsync(input.BookId);
            book.Author = newAuthor;
            await _bookManager.Update(book);
            return new AuthorDto { Id = authorId, Firstname = input.Firstname, Lastname = input.Lastname };
        }
        public override async Task<AuthorDto> UpdateAsync(AuthorDto input)
        {
           var author = await _authorManager.GetById(input.Id);
            ObjectMapper.Map(input, author);
            await _authorManager.UpdateAsync(author);
            return MapToEntityDto(author);
        }
    }
}
