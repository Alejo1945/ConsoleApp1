using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bodega
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public Bodega(string nombre, string direccion, string telefono, string email)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }
        public override string ToString()
        {
            return $"Bodega: {Nombre}, Dirección: {Direccion}, Teléfono: {Telefono}, Email: {Email}";
        }
    }
}
