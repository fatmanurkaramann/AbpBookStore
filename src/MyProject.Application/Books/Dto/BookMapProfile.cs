using AutoMapper;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Books.Dto
{
    public class BookMapProfile:Profile
    {
        public BookMapProfile()
        {
            CreateMap<Book,BookDto>().ReverseMap();
            CreateMap<Book, CreateBookDto>().ReverseMap();
        }
    }
}
