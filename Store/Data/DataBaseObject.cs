using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Data;

namespace Store.Data
{
    public class DataBaseObject
    {
        public static void Initial(DateBaseContent content)
        {
           
            if (!content.DbCategories.Any())
                content.DbCategories.AddRange(Categories.Select(c => c.Value));

            if (!content.DbGames.Any())
                content.AddRange(
                    new Game
                    {
                        name = "Fifa 21",
                        img = "/img/fifa-21-and-beyond.jpg",
                        author = "Electronic Arts",
                        description = "Серия компьютерных игр в жанре симулятора футбола, которая разрабатывается студией EA Canada, входящей в состав корпорации Electronic Arts.",
                        price = 4990,
                        Category = Categories["Симулятор"]
                    },

                    new Game
                    {
                        name = "Counter Strike GO",
                        img = "/img/xbKlqV.png",
                        author = "Valve Software",
                        description = "Counter-Strike: Global Offensive (CS: GO) возрождает ураганную командную игру, впервые представленную еще 19 лет назад. " +
                        "CS: GO включает в себя новые карты, персонажей, оружие, игровые режимы, а также улучшенную версию классической составляющей CS (de_dust и т.п.).",
                        price = 0,
                        Category = Categories["Шутер"]
                    },

                    new Game
                    {
                        name = "Need for Speed: Most Wanted",
                        img = "/img/maxresdefault-5-6.jpg",
                        author = "Electronic Art",
                        description = "Компьютерная игра серии Need for Speed в жанре аркадной автогонки, разработанная студией EA Canada и изданная компанией Electronic Arts для консолей, персональных компьютеров и мобильных телефонов",
                        price = 250,
                        Category = Categories["Гонки"]
                    },

                    new Game
                    {
                        name = "World of Tanks",
                        img = "/img/N4hWVl.jpg",
                        author = "Wargaming",
                        description = "Клиентская массовая многопользовательская онлайн-игра в реальном времени в жанре аркадного танкового симулятора, в которой представлены боевые машины середины XX века.",
                        price = 0,
                        Category = Categories["ММО-РПГ"]
                    }
                    );
            content.SaveChanges();
        }

        private static Dictionary<string,Models.Category> category;
        public static Dictionary<string,Models.Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Models.Category[]
                    {
                        new Category{name="Шутер",description="Стрелялка, широкий выбор стрелкового оружия"},
                        new Category{name="Гонки",description="Подойдет для тех, кто испытывает жажду скорости" },
                        new Category{name="Симулятор",description="Разного рода симуляции для получениях успеха хотя бы где-то"},
                        new Category{name="ММО-РПГ",description="Игры, которые потребуют от вас времени и терпения"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category element in list)
                        category.Add(element.name,element);

                }
                return category;
            }
        }
    }
}
