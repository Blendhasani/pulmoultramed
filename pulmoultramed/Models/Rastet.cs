using pulmoultramed.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace pulmoultramed.Models
{
    public class Rastet:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Emri { get; set; }

        public string Pershkrimi { get; set; }

        public  string FotoUrl { get; set; }


    }
}
