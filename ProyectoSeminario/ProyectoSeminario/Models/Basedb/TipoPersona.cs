
namespace Definitivo.Models.Basedb
{
    using System.ComponentModel.DataAnnotations;

    public class TipoPersona
    {
        [Key]
        public int TipoPersonaId { get; set; }
       
        [Required]
        [StringLength(40)]
        [Display(Name = "Tipo de persona")]
        public string NombreTipoPersona { get; set; }
    }
}
