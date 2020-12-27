using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store.Interfeces;
using Store.Models;
using Store.Data;
using Microsoft.EntityFrameworkCore;

namespace Store.Repository
{
    public class GameRepository : IAllGames
    {
        private readonly DateBaseContent dateBaseContent;

        public GameRepository(DateBaseContent dateBaseContent)
        {
            this.dateBaseContent = dateBaseContent;
        }
        public IEnumerable<Game> Games => dateBaseContent.DbGames.Include(c => c.Category);

        public Game getObjectGame(int gameId) => dateBaseContent.DbGames.FirstOrDefault(c =>c.id ==gameId);
    }
}
