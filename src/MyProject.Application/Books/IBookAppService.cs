using Abp.Application.Services;
using MyProject.Books.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Books
{
    public interface IBookAppService : IAsyncCrudAppService<BookDto,int, PagedBookResultRequestDto, CreateBookDto, BookDto>
    {
    }
}
