using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SePriseApp.Models;

namespace SePriseApp.Services
{
    public static class AuthService
    {
        // Lista en memoria — después se reemplaza por BD
        private static List<Empleado> _empleados = new List<Empleado>
        {
            new Empleado { Id=1, Nombre="José Luis", Apellido="Galvis",
                Usuario="admin", Password="1234", Rol="Supervisor", Activo=true },
            new Empleado { Id=2, Nombre="Maria", Apellido="López",
                Usuario="recepcion", Password="1234", Rol="Recepción", Activo=true }
        };

        public static Empleado? Login(string usuario, string password)
        {
            return _empleados.FirstOrDefault(e =>
                e.Usuario == usuario &&
                e.Password == password &&
                e.Activo);
        }

        public static bool Registrar(Empleado empleado)
        {
            if (_empleados.Any(e => e.Usuario == empleado.Usuario))
                return false; // usuario ya existe

            empleado.Id = _empleados.Count + 1;
            _empleados.Add(empleado);
            return true;
        }
    }
}
