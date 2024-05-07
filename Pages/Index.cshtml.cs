using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VideoGame.Models;

namespace VideoGame.Pages;

public class IndexModel : PageModel
{
    private readonly GameDbContext _context;
    private readonly ILogger<IndexModel> _logger;
    public List<Game> Games {get; set;}  = default!;
    public SelectList GamesDropDown {get; set;}  = default!;

    public IndexModel(GameDbContext context, ILogger<IndexModel> logger)
    {
        _logger = logger;
        _context = context;
    }

    public void OnGet()
    {
        Games = _context.Games.ToList();
        GamesDropDown = new SelectList(Games, "GameId", "Title");
    }
}
