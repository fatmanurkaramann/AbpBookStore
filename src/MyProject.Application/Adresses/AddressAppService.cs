using Abp.Application.Services;
using Abp.Domain.Repositories;
using MyProject.Adresses.Dto;
using MyProject.Categories.Dto;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Adresses
{
    public class AddressAppService : AsyncCrudAppService<Address, AddressDto, int, AddressDto, CreateAddressDto, AddressDto>
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

    }
}
