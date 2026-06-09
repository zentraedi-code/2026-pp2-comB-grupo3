namespace Seprise.entity
{
    public class Medico
    {
        private int id;
        private string matricula;
        private string nombre;
        private string apellido;
        private int especialidadId;
        private string especialidadNombre;
        private decimal importeConsulta;
        private int duracionMinimaTurno;
        private bool activo;

        public Medico(int id, string matricula, string nombre, string apellido, int especialidadId, string especialidadNombre, decimal importeConsulta, bool activo, int duracionMinimaTurno = 15)
        {
            this.Id = id;
            this.Matricula = matricula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.EspecialidadId = especialidadId;
            this.EspecialidadNombre = especialidadNombre;
            this.ImporteConsulta = importeConsulta;
            this.Activo = activo;
            this.DuracionMinimaTurno = duracionMinimaTurno;
        }

        public int Id { get => id; set => id = value; }
        public int IdEspecialidad { get => especialidadId; set => especialidadId = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int EspecialidadId { get => especialidadId; set => especialidadId = value; }
        public string EspecialidadNombre { get => especialidadNombre; set => especialidadNombre = value; }
        public decimal ImporteConsulta { get => importeConsulta; set => importeConsulta = value; }
        public int DuracionMinimaTurno { get => duracionMinimaTurno; set => duracionMinimaTurno = value; }
        public bool Activo { get => activo; set => activo = value; }

        public string ObtenerNombreCompleto()
        {
            return $"{this.Nombre} {this.Apellido}";
        }

        public override string ToString()
        {
            return ObtenerNombreCompleto();
        }
    }
}