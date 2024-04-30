using Microsoft.EntityFrameworkCore;
using VideoGame.Models;

namespace VideoGame.Models
{
	public class GameDbContext : DbContext
	{
		public GameDbContext (DbContextOptions<GameDbContext> options)
			: base(options)
		{
		}
		public DbSet<Game> Games {get; set;} = default!;
		

	}
}