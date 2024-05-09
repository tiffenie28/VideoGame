using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VideoGame.Models;

namespace VideoGame.Pages.Games
{
    public class SearchModel : PageModel
    {
        private readonly GameDbContext _context;

        public SearchModel(GameDbContext context)
        {
            _context = context;
        }

        public List<GameWithCharactersViewModel> GamesWithCharacters { get; set; } = new List<GameWithCharactersViewModel>();

        public async Task OnGetAsync(string? searchQuery)
        {
            if (!string.IsNullOrEmpty(searchQuery))
            {
                var gamesWithCharactersQuery =
                    from game in _context.Games
                    join character in _context.Characters on game.GameId equals character.GameId
                    where game.Title.Contains(searchQuery) || character.Name.Contains(searchQuery) || character.User.Contains(searchQuery)
                    select new { Game = game, Character = character };

                var gamesWithCharacters = await gamesWithCharactersQuery.ToListAsync();

                
                var groupedGamesWithCharacters = gamesWithCharacters.GroupBy(gc => gc.Game);

                foreach (var groupedGameWithCharacters in groupedGamesWithCharacters)
                {
                    var gameViewModel = new GameWithCharactersViewModel
                    {
                        Game = groupedGameWithCharacters.Key,
                        Characters = groupedGameWithCharacters.Select(gc => gc.Character).ToList()
                    };
                    GamesWithCharacters.Add(gameViewModel);
                }
            }
        }
    }

    public class GameWithCharactersViewModel
    {
        public Game Game { get; set; }
        public List<Character> Characters { get; set; }
    }
}


