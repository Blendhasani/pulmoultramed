using System.ComponentModel.DataAnnotations;

namespace pulmoultramed.Data.ViewComponents
{
    public class NewSherbimeVM
    {

        public int Id { get; set; }

        [Display(Name = "Emri i sherbimit")]
        [Required(ErrorMessage = "Emri duhet te plotesohet")]
        public string Emri { get; set; }

        [Display(Name = "Pershkrimi i sherbimit")]
        [Required(ErrorMessage = "Pershkrimi duhet te plotesohet")]
        public string Pershkrimi { get; set; }

        [Display(Name = "Foto e sherbimit")]
        [Required(ErrorMessage = "Linku i fotos duhet te plotesohet")]
        public string FotoUrl { get; set; }

    }
    
}
