using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyProject.Authors.Dto;
using MyProject.Categories.Dto;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Books.Dto
{
    [AutoMapFrom(typeof(Book))]
    public class BookDto:EntityDto<int>
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "Fiyat giriniz.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Sayfa sayısı giriniz.")]
        public int PageCount { get; set; }
        public string ImagePath { get; set; }
        public DateTime PublishDate { get; set; }
        public string Description { get; set; }
        public AuthorDto Author { get; set; }
        public CategoryDto Category { get; set; }
    }
}
