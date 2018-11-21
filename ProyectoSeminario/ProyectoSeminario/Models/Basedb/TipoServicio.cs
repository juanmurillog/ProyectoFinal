

namespace Definitivo.Models.Basedb
{
    using System.ComponentModel.DataAnnotations;

    public class TipoServicio
    {
        [Key]
        public int TipoServicioId { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Tipo de servicio")]
        public string NombreTipoServicio { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Descripcion")]
        public string DescripcionTipoServicio { get; set; }

    }    
}
