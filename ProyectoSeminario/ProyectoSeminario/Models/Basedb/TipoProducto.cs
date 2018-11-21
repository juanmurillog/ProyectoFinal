

namespace Definitivo.Models.Basedb
{
    using System.ComponentModel.DataAnnotations;

    public class TipoProducto
    {
        [Key]
        public int TipoProductoId { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Tipo de producto")]
        public string NombreTipoProducto { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Descripcion")]
        public string DescripcionTipoProducto { get; set; }
    }
}
