﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public interface ICategoryManager
    {
        Task<Category> Create(Category category);
    }
}
