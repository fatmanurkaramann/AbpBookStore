using Abp.Application.Services;
using Abp.Domain.Repositories;
using MyProject.Adresses.Dto;
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
        public AddressAppService(IRepository<Address, int> repository) : base(repository)
        {
        }
    }
}
