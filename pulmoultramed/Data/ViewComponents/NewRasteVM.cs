using System.ComponentModel.DataAnnotations;

namespace pulmoultramed.Data.ViewComponents
{
    public class NewRasteVM
    {
        public int Id { get; set; }

        [Display(Name = "Emri i rastit")]
        [Required(ErrorMessage = "Emri duhet te plotesohet")]
        public string Emri { get; set; }

        [Display(Name = "Pershkrimi i rastit")]
        [Required(ErrorMessage = "Pershkrimi duhet te plotesohet")]
        public string Pershkrimi { get; set; }

        [Display(Name = "Foto e rastit")]
        [Required(ErrorMessage = "Linku i fotos duhet te plotesohet")]
        public string FotoUrl { get; set; }
    }
}
