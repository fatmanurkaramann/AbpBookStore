using AutoMapper;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Authors.Dto
{
    public class AuthorMapProfile : Profile
    {
        public AuthorMapProfile()
        {
            CreateMap<CreateAuthorDto, Author>().ReverseMap();
            CreateMap<AuthorDto, Author>().ReverseMap();

        }
    }

}

