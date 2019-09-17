using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [MinLength(4, ErrorMessage = "Paswoord moet minstens 4 tekens lang zijn.")]
        public string Password { get; set; }
    }
}