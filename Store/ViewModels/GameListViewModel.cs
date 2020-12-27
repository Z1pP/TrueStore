using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Models;

namespace Store.ViewModels
{
    public class GameListViewModel
    {
        public IEnumerable<Game> allGames { get; set; }

        public string gameCategory { get; set; }
    }
}
