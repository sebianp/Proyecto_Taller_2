using System;

namespace Entidades
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string TipoPersona { get; set; } //Con este campo diferenciamos si se trata de un cliente o proveedor
        public string Nombre { get; set; }
        public string TipoDocumento { get; set; }
        public string NumDocumento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
