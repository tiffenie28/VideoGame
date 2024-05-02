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
                        Genre = "MMO",
                        Platform = "PC"
                    },

                    new Game
                    {
                       Title = "Fortnight",
                        Genre = "Battle Royale",
                        Platform = "Playstation"
                        
                    },

                    new Game
                    {
                        Title = "Bendy & The Dark Rival",
                        Genre = "Adventure",
                        Platform = "Playstation"
                        
                    },

                     new Game
                    {
                        Title = "Roblox",
                        Genre = "Adventure",
                        Platform = "Playstation"
                        
                    },
                     new Game
                    {
                        Title = "Fallout",
                        Genre = "RPG",
                        Platform = "Playstation"
                        
                    },

                      new Game
                    {
                        Title = "Minecraft",
                        Genre = "Adventure",
                        Platform = "Playstation"
                        
                    },

                       new Game
                    {
                        Title = "StarDew Valley",
                        Genre = "RPG",
                        Platform = "PC"
                        
                    },
                      new Game
                    {
                       Title = "Among Us",
                        Genre = "Adventure",
                        Platform = "PC"
                        
                    }
                );

                context.SaveChanges();
            }
        
        }
    }