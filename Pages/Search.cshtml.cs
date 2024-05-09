using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        public IList<Game> Games { get;set; }

        public async Task OnGetAsync(string? searchQuery)
        {
            if (!string.IsNullOrEmpty(searchQuery))
            {
                // Perform search for games or users based on the search query
                Games = await _context.Games
                    .Include(g => g.Characters)
                    .Where(g => g.Title.Contains(searchQuery) || g.Characters.Any(c => c.User.Contains(searchQuery)))
                    .ToListAsync();
            }
            else
            {
                // If no search query provided, retrieve all games
                Games = await _context.Games
                    .Include(g => g.Characters)
                    .ToListAsync();
            }
        }
    }
}
