using System.ComponentModel.DataAnnotations;

namespace pulmoultramed.Data.ViewComponents
{
    public class LoginVM
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address eshte e zbrazet")]
        public string EmailAddress { get; set; }



        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
