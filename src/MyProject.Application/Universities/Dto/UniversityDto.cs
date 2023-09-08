using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Universities.Dto
{
    [AutoMapFrom(typeof(University))]
    public class UniversityDto
    {
        public string UniversityName { get; set; }
    }
}
