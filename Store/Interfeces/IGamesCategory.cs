using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Models;

namespace Store.Interfeces
{
     public interface IGamesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
