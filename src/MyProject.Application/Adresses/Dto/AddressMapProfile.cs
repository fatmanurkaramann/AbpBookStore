using AutoMapper;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Adresses.Dto
{
    public class AddressMapProfile:Profile
    {
        public AddressMapProfile()
        {
            CreateMap<CreateAddressDto, Address>().ReverseMap();
            CreateMap<AddressDto, Address>().ReverseMap();

        }
    }
}
