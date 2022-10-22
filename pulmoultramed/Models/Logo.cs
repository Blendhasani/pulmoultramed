using System.ComponentModel.DataAnnotations;

namespace pulmoultramed.Models
{
    public class Logo
    {
        [Key]
        public int Id { get; set; }
        public string LogoUrl { get; set; }
    }
}
