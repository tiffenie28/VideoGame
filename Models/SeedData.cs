using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace VideoGame.Models;

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GameDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<GameDbContext>>()))
        {
                

                if (context.Games.Any())
                {
                    return; 
                }
                
                
                context.Games.AddRange(
                    new Game
                    {
                        Title = "World of Warcraft",
                        Genre = "The Grey",
                        Platform = "PC"
                    },
                    new Game
                    {
                       Title = "Fortnight",
                        Genre = "The Grey",
                        Platform = "Playstation"
                        
                    },
                    new Game
                    {
                        Title = "Bendy & The Dark Rival",
                        Genre = "The Grey",
                        Platform = "Playstation"
                        
                    },

                     new Game
                    {
                        Title = "Roblox",
                        Genre = "The Grey",
                        Platform = "Playstation"
                        
                    },

                      new Game
                    {
                        Title = "Minecraft",
                        Genre = "The Grey",
                        Platform = "Playstation"
                        
                    },

                       new Game
                    {
                        Title = "StarDew Valley",
                        Genre = "The Grey",
                        Platform = "PC"
                        
                    }
                );

                context.SaveChanges();
            }
        
        }
    }