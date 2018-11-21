
namespace Definitivo.Models.Basedb
{
    using System.ComponentModel.DataAnnotations;

    public class Persona
    {
        [Key]
        public int PersonaId { get; set; }

        [Display(Name = "Usuario")]
        public int UserId { get; set; }

        [Display(Name = "Persona")]
        public int TipoPersonaId { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Nombre")]
        public string NombrePersona { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Correo")]
        public string Correo { get; set; }

    }
}
