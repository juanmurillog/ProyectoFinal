

namespace Definitivo.Models.Basedb
{
    using System.ComponentModel.DataAnnotations;

    public class TipoPago
    {
        [Key]
        public int TipoPagoId { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Tipo Pago")]
        public string NombreTipoPago { get; set; }

    }
}
