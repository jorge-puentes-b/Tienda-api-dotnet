using System.ComponentModel.DataAnnotations;

namespace TiendaApi.DTOs
{
    public class CrearProductoDto
    {
        //Anotaciones con Data Annotations
        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(100, ErrorMessage = "El nombre debe tener menos de 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El precio es requerido")]
        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "El stock es requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "El stock debe ser mayor o igual a 0")]
        public int Stock { get; set; }
    }
}
