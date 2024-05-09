using System.ComponentModel.DataAnnotations;

namespace VideoGame.Models


{
    public class Character
   {
        public int? CharacterId { get; set; }
      
        public string? Name { get; set; }
        public int? Level { get; set; }
        public int? GameId { get; set; }
       
        public string? User { get; set; } //FK
        public Game? Game { get; set; } //Navigation
        
    }
}