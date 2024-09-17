using System.ComponentModel.DataAnnotations;

namespace SendEmails.Dtos
{
    public class WelcomeRequestDto
    {
        [Required(ErrorMessage = "Plz enter UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Plz enter Email")]
        public string Email { get; set; }
    }
}
