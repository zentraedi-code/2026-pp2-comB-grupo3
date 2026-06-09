using System;

namespace Seprise.entity
{
    public class Consultorio
    {
        private int id;
        private string nombre;
        private bool activo;

        public Consultorio(int id, string nombre, bool activo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Activo = activo;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool Activo { get => activo; set => activo = value; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
