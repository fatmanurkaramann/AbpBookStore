using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Authors.Dto
{
    public class PagedAuthorResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
