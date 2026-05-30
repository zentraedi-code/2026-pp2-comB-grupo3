using System;

namespace Seprise.entity
{
    public class Medico
    {
        private int id;
        private string nombre;
        private string apellido;
        private string matricula;
        private int idEspecialidad;
        private string especialidad;
        private int duracionMinimaTurno;
        private bool activo;

        public Medico(int id, string nombre, string apellido, string matricula, int idEspecialidad, string especialidad, int duracionMinimaTurno, bool activo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Matricula = matricula;
            this.IdEspecialidad = idEspecialidad;
            this.Especialidad = especialidad;
            this.DuracionMinimaTurno = duracionMinimaTurno;
            this.Activo = activo;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public int DuracionMinimaTurno { get => duracionMinimaTurno; set => duracionMinimaTurno = value; }
        public bool Activo { get => activo; set => activo = value; }

        public override string ToString()
        {
            return $"{Apellido}, {Nombre} - {Especialidad}";
        }
    }
}
