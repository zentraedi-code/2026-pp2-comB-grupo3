using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seprise.entity
{
    public class Paciente
    {
        private int id;
        private string dni;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private string telefono;
        private string obraSocial;
        private bool activo;

        public Paciente(int id, string dni, string nombre, string apellido, DateTime fechaNacimiento, string telefono, string obraSocial, bool activo)
        {
            this.Id = id;
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.Telefono = telefono;
            this.ObraSocial = obraSocial;
            this.Activo = activo;
        }

        public int Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string ObraSocial { get => obraSocial; set => obraSocial = value; }
        public bool Activo { get => activo; set => activo = value; }

        public int CalcularEdad()
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - this.FechaNacimiento.Year;

            if (this.FechaNacimiento.Date > hoy.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        public string ObtenerNombreCompleto()
        {
            return $"{this.Nombre} {this.Apellido}";
        }
    }
}
