
namespace Proyecto.Models.Basedb
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Alquiler
    {
        [Key]
        public int AlquilerId { get; set; }
      
        [Display(Name = "Producto")]
        public int ProductoId { get; set; }

        [Display(Name = "Persona")]
        public int PersonaId { get; set; }

        [Display(Name = "Tipo de pago")]
        public int TipoPagoId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de salida")]
        public DateTime FechaSalida { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de entrada")]
        public DateTime FechaEntrada { get; set; }
      
        [Display(Name = "Total alquiler")]
        public int TotalAlquiler { get; set; }
    

    }
}
