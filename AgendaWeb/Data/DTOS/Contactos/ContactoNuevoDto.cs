using System.ComponentModel.DataAnnotations;

namespace AgendaWeb.Data.DTOS.Contactos
{
    public class ContactoNuevoDto
    {
        [Required]
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
