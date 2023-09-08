using Abp.AutoMapper;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Adresses.Dto
{
    [AutoMapFrom(typeof(Address))]
    public class CreateAddressDto
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
