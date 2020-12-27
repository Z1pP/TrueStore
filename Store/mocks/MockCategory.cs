using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Interfeces;
using Store.Models;

namespace Store.mocks
{
    public class MockCategory : IGamesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{name="Шутер",description="Стрелялка, широкий выбор стрелкового оружия"},
                    new Category{name="Гонки",description="Подойдет для тех, кто испытывает жажду скорости" },
                    new Category{name="Симулятор",description="Разного рода симуляции для получениях успеха хотя бы где-то"},
                    new Category{name="ММО-РПГ",description="Игры, которые потребуют от вас времени и терпения"}
                };

            }
        }
    }
}
