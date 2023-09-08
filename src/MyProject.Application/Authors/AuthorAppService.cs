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
        public AuthorAppService(IRepository<Author, int> repository, IAuthorManager authorManager) : base(repository)
        {
            _authorManager = authorManager;
        }

        public override async Task<AuthorDto> CreateAsync(CreateAuthorDto input)
        {
            var author = ObjectMapper.Map<Author>(input);
            await _authorManager.Create(author);

            return MapToEntityDto(author);
        }
    }
}
