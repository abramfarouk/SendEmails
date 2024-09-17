using System.ComponentModel.DataAnnotations;

namespace SendEmails.Dtos
{
    public class WelcomeRequestDto
    {
        [Required(ErrorMessage = "Plz enter UserName")]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
