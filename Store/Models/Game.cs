using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Game
    {
        public int id { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public string author { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public int categoryId { get; set; }
        public virtual Category Category { get; set; } // объект на основе определенной категории 

    }
}
