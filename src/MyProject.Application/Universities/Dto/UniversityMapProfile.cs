using AutoMapper;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Universities.Dto
{
    public class UniversityMapProfile : Profile
    {
        public UniversityMapProfile()
        {
            CreateMap<UniversityDto, University>().ReverseMap();
            CreateMap<University, UniversityDto>().ReverseMap();
        }
    }
}
