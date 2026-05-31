namespace Seprise.entity
{
    public class Especialidad
    {
        private int id;
        private string nombre;
        private string descripcion;
        private int duracionMinimaTurno;
        private bool activo;

        public Especialidad(int id, string nombre, string descripcion, int duracionMinimaTurno, bool activo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.DuracionMinimaTurno = duracionMinimaTurno;
            this.Activo = activo;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int DuracionMinimaTurno { get => duracionMinimaTurno; set => duracionMinimaTurno = value; }
        public bool Activo { get => activo; set => activo = value; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}