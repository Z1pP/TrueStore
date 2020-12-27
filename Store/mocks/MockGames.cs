using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Interfeces;
using Store.Models;

namespace Store.mocks
{
    class MockGames : IAllGames
    {
        private readonly IGamesCategory _gamesCategory = new MockCategory();
        private Category category = new Category();
        public IEnumerable<Game> Games {
            get 
            {
                return new List<Game>
                {
                    new Game
                    {name="Fifa 21",
                        img="/img/fifa-21-and-beyond.jpg", 
                        author="Electronic Arts", 
                        description = "Серия компьютерных игр в жанре симулятора футбола, которая разрабатывается студией EA Canada, входящей в состав корпорации Electronic Arts.",
                        price= 4990,
                        Category=_gamesCategory.AllCategories.FirstOrDefault(x => x.name=="Симулятор")
                    },

                    new Game
                    {name="Counter Strike GO",
                        img="/img/xbKlqV.png",
                        author="Valve Software", 
                        description="Counter-Strike: Global Offensive (CS: GO) возрождает ураганную командную игру, впервые представленную еще 19 лет назад. " +
                        "CS: GO включает в себя новые карты, персонажей, оружие, игровые режимы, а также улучшенную версию классической составляющей CS (de_dust и т.п.).",
                        price=0,
                        Category=_gamesCategory.AllCategories.FirstOrDefault(x => x.name=="Шутер")
                    },

                    new Game
                    {name="Need for Speed: Most Wanted",
                        img="/img/maxresdefault-5-6.jpg",
                        author="Electronic Art",
                        description="Компьютерная игра серии Need for Speed в жанре аркадной автогонки, разработанная студией EA Canada и изданная компанией Electronic Arts для консолей, персональных компьютеров и мобильных телефонов",
                        price=250,
                        Category=_gamesCategory.AllCategories.FirstOrDefault(x => x.name=="Гонки")
                    },

                    new Game
                    {name="World of Tanks", 
                        img="/img/N4hWVl.jpg",
                        author="Wargaming",
                        description="Клиентская массовая многопользовательская онлайн-игра в реальном времени в жанре аркадного танкового симулятора, в которой представлены боевые машины середины XX века.",
                        price=0,
                        Category=_gamesCategory.AllCategories.FirstOrDefault(x => x.name=="ММО-РПГ")
                    }
                };
            }
        }

        public Game getObjectGame(int gameId)
        {
            throw new NotImplementedException();
        }
    }
}
