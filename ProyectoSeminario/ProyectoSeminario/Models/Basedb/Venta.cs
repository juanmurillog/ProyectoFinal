namespace Proyecto.Models.Basedb
{
    using System.ComponentModel.DataAnnotations;

    public class Venta
    {

        [Key]
        public int VentaId { get; set; }

        [Display(Name = "Producto")]
        public int ProductoId { get; set; }

        [Display(Name = "Persona")]
        public int PersonaId { get; set; }

        [Display(Name = "Tipo de pago")]
        public int TipoPagoId { get; set; }

        [Display(Name = "Total venta")]
        public double TotalVenta { get; set; }

    }
}
