using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VideoGame.Models;


namespace VideoGame.Pages;

public class CreateModel : PageModel
{
    private readonly GameDbContext _context;
    private readonly ILogger<CreateModel> _logger;

    [BindProperty]
    public Game Game { get; set; } = default!;
   

    public CreateModel(GameDbContext context, ILogger<CreateModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

    _context.Games.Add(Game);
    _context.SaveChanges();

    return RedirectToPage("./Index");
}
}