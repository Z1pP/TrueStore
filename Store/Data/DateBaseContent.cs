using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Store.Models;

namespace Store.Data
{
    public class DateBaseContent : DbContext
    {
        public DateBaseContent(DbContextOptions<DateBaseContent> contextOptions) :base(contextOptions)
        {
            Database.EnsureCreated(); //Создаем базу данных при первом обращении
        }

        public DbSet<Game> DbGames { get; set; }
        public DbSet<Category> DbCategories { get; set; }
    }
}
