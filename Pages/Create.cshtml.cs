using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VideoGame.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace VideoGame.Pages
{
public class CreateModel : PageModel
{
    private readonly GameDbContext _context;
    private readonly ILogger<CreateModel> _logger;

    [BindProperty]
    public int ProfessorId { get; set; }

    public Game Professor { get; set; } 
    public List<Game> Professors { get; set; }
    public SelectList GamesDropDown { get; set; }

    public CreateModel(GameDbContext context, ILogger<CreateModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        Professors = _context.Games.ToList();
        GamesDropDown = new SelectList(Games, "GameId", "Title");
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Professor = await _context.Games.FindAsync(ProfessorId);

        return Page();
    }
}
}