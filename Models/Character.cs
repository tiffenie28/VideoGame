using System.ComponentModel.DataAnnotations;

namespace VideoGame.Models


{
    public class Character
   {
        public int? CharacterId { get; set; }
       [Required]
       [StringLength(50, MinimumLength = 5)]
        public string? Name { get; set; }
        public int? Level { get; set; }
        public int? GameId { get; set; }
       [Required]
        public string? User { get; set; } //FK
        public Game? Game { get; set; } //Navigation
        
    }
}