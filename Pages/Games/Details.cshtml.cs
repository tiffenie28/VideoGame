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
    public class DetailsModel : PageModel
    {
        private readonly VideoGame.Models.GameDbContext _context;

        public DetailsModel(VideoGame.Models.GameDbContext context)
        {
            _context = context;
        }

        public Game Game { get; set; } = default!;
        [BindProperty]
        public Character Character { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Games.Include(m => m.Characters).FirstOrDefaultAsync(m => m.GameId == id);
            if (game == null)
            {
                return NotFound();
            }
            else
            {
                Game = game;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            // Associate character with the game
            Character.GameId = game.GameId;

            // Save character to database
            _context.Characters.Add(Character);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Details", new { id });
        }

        public async Task<IActionResult> OnPostDeleteAsync(int? gameId, int? characterId)
        {
            if (gameId == null || characterId == null)
            {
                return NotFound();
            }

            var game = await _context.Games.FindAsync(gameId);
            if (game == null)
            {
                return NotFound();
            }

            var character = await _context.Characters.FindAsync(characterId);
            if (character == null)
            {
                return NotFound();
            }

            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Details", new { id = gameId });
        }
    }
}


