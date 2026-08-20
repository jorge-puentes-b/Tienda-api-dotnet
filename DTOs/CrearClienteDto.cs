using System.ComponentModel.DataAnnotations;

namespace TiendaApi.DTOs
{
    public class CrearClienteDto
    {
        //Anotaciones con Data Annotations
        [Required(ErrorMessage = "El nombre es requerido")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "El email no es valido")]
        public string? Email { get; set; }
    }
}