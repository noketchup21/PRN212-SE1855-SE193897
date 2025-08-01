﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects_EF;
using Repositories_EF;

namespace Services_EF
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository repository;
        public CategoryService()
        {
            repository = new CategoryRepository();
        }
        public List<Category> GetCategories()
        {
            return repository.GetCategories();
        }
    }
}
