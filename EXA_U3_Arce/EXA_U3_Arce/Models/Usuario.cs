using System.ComponentModel.DataAnnotations;

namespace EXA_U3_Arce.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Rol { get; set; } // "admin" o "user"
    }
}
