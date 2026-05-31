namespace Seprise.entity
{
    public class AgendaMedica
    {
        private int id;
        private int medicoId;
        private int consultorioId;
        private DateTime fecha;
        private TimeSpan horaDesde;
        private TimeSpan horaHasta;
        private int duracionTurnoMinutos;
        private int sobreTurnosPorHora;
        private EstadoAgendaMedica estado;

        public AgendaMedica(int medicoId, int consultorioId, DateTime fecha, TimeSpan horaDesde, TimeSpan horaHasta, int duracionTurnoMinutos, int sobreTurnosPorHora, EstadoAgendaMedica estado)
        {
            this.MedicoId = medicoId;
            this.ConsultorioId = consultorioId;
            this.Fecha = fecha;
            this.HoraDesde = horaDesde;
            this.HoraHasta = horaHasta;
            this.DuracionTurnoMinutos = duracionTurnoMinutos;
            this.SobreTurnosPorHora = sobreTurnosPorHora;
            this.Estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public int MedicoId { get => medicoId; set => medicoId = value; }
        public int ConsultorioId { get => consultorioId; set => consultorioId = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public TimeSpan HoraDesde { get => horaDesde; set => horaDesde = value; }
        public TimeSpan HoraHasta { get => horaHasta; set => horaHasta = value; }
        public int DuracionTurnoMinutos { get => duracionTurnoMinutos; set => duracionTurnoMinutos = value; }
        public int SobreTurnosPorHora { get => sobreTurnosPorHora; set => sobreTurnosPorHora = value; }
        public EstadoAgendaMedica Estado { get => estado; set => estado = value; }
    }
}
