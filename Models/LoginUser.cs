using System.ComponentModel.DataAnnotations; //Validations


namespace Register_Login.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Email address is required")]
        [DataType(DataType.EmailAddress)]
        public string UserEmail {get;set;}

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Password must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string UserPassword {get;set;}

    }
}