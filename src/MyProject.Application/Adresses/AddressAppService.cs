using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Extensions;
using MyProject.Adresses.Dto;
using MyProject.Books.Dto;
using MyProject.Categories.Dto;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Adresses
{
    public class AddressAppService : AsyncCrudAppService<Address, AddressDto, int, PagedAddressResultRequestDto, CreateAddressDto, AddressDto>
    {
        private readonly IAddressManager _addressManager;
        public AddressAppService(IRepository<Address, int> repository, IAddressManager addressManager) : base(repository)
        {
            _addressManager = addressManager;
        }
        public override async Task<AddressDto> CreateAsync(CreateAddressDto input)
        {
            var address = new Address
            {
                City = input.City,
                Country = input.Country,
                Street = input.Street,
            };
            await _addressManager.CreateAsync(address);
            return MapToEntityDto(address);
        }

        protected override IQueryable<Address> CreateFilteredQuery(PagedAddressResultRequestDto input)
        {
            var query = Repository.GetAllIncluding(x => x.Author);

            if (!input.Keyword.IsNullOrWhiteSpace())
            {
                query = query.Where(x => x.City.Contains(input.Keyword) || x.Street.Contains(input.Keyword));
            }

            return query;
        }

    }
}
