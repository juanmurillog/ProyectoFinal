

namespace Definitivo.Models.Basedb
{
    using System.ComponentModel.DataAnnotations;

    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        [Display(Name = "Tipo de Producto")]
        public int TipoProductoId { get; set; }

        [Display(Name = "Tipo de servicio")]
        public int TipoServicioId { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Producto")]
        public string NombreProducto { get; set; }

        [Required]
        [StringLength(400)]
        [Display(Name = "Descripcion")]
        public string DescripcionProducto { get; set; }

        [Display(Name = "Valor del Producto")]
        public double ValorProducto { get; set; }


    }
}
