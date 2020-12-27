using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Interfeces;
using Store.Models;
using Microsoft.EntityFrameworkCore;
using Store.Data;

namespace Store.Repository
{
    public class CategoryRepository : IGamesCategory
    {
        private readonly DateBaseContent dateBaseContent;

        public CategoryRepository(DateBaseContent dateBaseContent)
        {
            this.dateBaseContent = dateBaseContent;
        }
        public IEnumerable<Category> AllCategories => dateBaseContent.DbCategories;
    }
}
