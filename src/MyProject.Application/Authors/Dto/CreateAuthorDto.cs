using Abp.AutoMapper;
using MyProject.Adresses.Dto;
using MyProject.Models;
using MyProject.Universities.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Authors.Dto
{
    [AutoMapFrom(typeof(Author))]
    public class CreateAuthorDto
    {
        [Required]
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public ICollection<CreateAddressDto> Addresses { get; set; }
        public ICollection<UniversityDto> Universities { get; set; }
        public int BookId { get; set; }
        public int AddressId { get; set; }
    }
}
