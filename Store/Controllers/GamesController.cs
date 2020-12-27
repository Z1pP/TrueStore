using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Interfeces;
using Store.ViewModels;

namespace Store.Controllers
{
    public class GamesController : Controller
    {
        private readonly IAllGames _allGames;
        private readonly IGamesCategory _gamesCategory;

        public GamesController(IAllGames iallGames,IGamesCategory igamesCategory)
        {
            _allGames = iallGames;
            _gamesCategory = igamesCategory;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Страница с играми";
            GameListViewModel gameListViewModel = new GameListViewModel();
            gameListViewModel.allGames = _allGames.Games;
            gameListViewModel.gameCategory = "Игры";
            return View(gameListViewModel);
        }
    }
}
