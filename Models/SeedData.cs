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
                
                
                var games = new List<Game>
                {
                    
                    new Game
                    {
                        Title = "World of Warcraft",
                        Genre = "MMO",
                        Platform = "PC",
                                  
                    },

                    new Game
                    {
                       Title = "Fortnight",
                        Genre = "Battle Royale",
                        Platform = "Playstation",
                           
                    },

                    new Game
                    {
                        Title = "Bendy & The Dark Rival",
                        Genre = "Adventure",
                        Platform = "Playstation",
                       
                    },

                     new Game
                    {
                        Title = "Roblox",
                        Genre = "Adventure",
                        Platform = "Playstation",
                        Characters = new List<Character> {
                          new Character 
                            {Name = "Bro",
                            Level = 1, 
                            User = "Axel"},
                             new Character 
                            {Name = "Aymesy",
                            Level = 1, 
                            User = "Aymes"}
                        }
                        
                    },
                     new Game
                    {
                        Title = "Fallout",
                        Genre = "RPG",
                        Platform = "Playstation",
                        Characters = new List<Character> {
                          new Character 
                            {Name = "Gator",
                            Level = 219, 
                            User = "Brett"},
                            new Character 
                            {Name = "Strife",
                            Level = 20, 
                            User = "Brett"},
                        }
                        
                    },

                      new Game
                    {
                        Title = "Minecraft",
                        Genre = "Adventure",
                        Platform = "Playstation",
                        Characters = new List<Character> {
                        new Character 
                            {Name = "Kids53",
                            Level = 1, 
                            User = "Axel"},
                            new Character 
                            {Name = "Anyone",
                            Level = 1, 
                            User = "Axel"},
                    }
                        
                    },

                       new Game
                    {
                        Title = "StarDew Valley",
                        Genre = "RPG",
                        Platform = "PC",
                         Characters = new List<Character> {
                        new Character 
                            {Name = "Kelty",
                            Level = 1, 
                            User = "Tiffenie"},
                            new Character 
                            {Name = "Oath",
                            Level = 1, 
                            User = "Brett"}
                         }
                        
                    },
                      new Game
                    {
                       Title = "Among Us",
                        Genre = "Adventure",
                        Platform = "PC",
                        Characters = new List<Character> {
                        new Character 
                            {Name = "Rose",
                            Level = 1, 
                            User = "Aymes"},
                            new Character 
                            {Name = "Lime",
                            Level = 1, 
                            User = "Axel"}
                        
                    }
                    }
                }
        }
                );

                context.Games.AddRange(games);
                context.SaveChanges();

                var characters = new List<Character>
                {
                    new Character {Name = "Keltee", Level = 70,User = "Tiffenie", GameId = 1},
                    new Character {Name = "Insox", Level = 70, User = "Tiffenie", GameId = 1},
                    new Character {Name = "Kelwinn", Level = 70, User = "Tiffenie", GameId = 1},
                    new Character {Name = "Aukya", Level = 56, User = "Tiffenie", GameId = 1},
                    new Character {Name = "Faytell", Level = 2, User = "Tiffenie", GameId = 1},
                    new Character {Name = "Kelps", Level = 1, User = "Tiffenie", GameId = 1},
                    new Character {Name = "Oathbringer", Level = 70, User = "Brett", GameId = 1},
                    new Character {Name = "Oathwarden", Level = 66, User = "Brett", GameId = 1},
                    new Character {Name = "Oathstalker", Level = 70, User = "Brett", GameId = 1},
                    new Character {Name = "Oathwarder", Level = 53, User = "Brett", GameId = 1},
                    new Character {Name = "Oathtaker", Level = 70, User = "Brett", GameId = 1},
                    new Character {Name = "Oathbound", Level = 60, User = "Brett", GameId = 1},
                    new Character {Name = "Fishstick", Level = 42, User = "Axel", GameId = 2},
                    new Character {Name = "Peely", Level = 40, User = "Axel", GameId = 2},
                    new Character {Name = "kids53", Level = 40, User = "Aymes", GameId = 2},
                    new Character {Name = "Bendy", Level = 21, User = "Axel", GameId = 3},
                        }
                }
            }
        
        }
    }