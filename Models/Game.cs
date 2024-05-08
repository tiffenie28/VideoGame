using System.ComponentModel.DataAnnotations;

namespace VideoGame.Models


{
    public class Game
   {
        public int? GameId { get; set; }
       [Required]
       [StringLength(100, MinimumLength = 5)]
        public string? Title { get; set; }
        public string? Genre { get; set; }
       
        public string? Platform { get; set; }
        
    }
}