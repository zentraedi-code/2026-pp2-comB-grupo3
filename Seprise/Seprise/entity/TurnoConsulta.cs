using System;

namespace Seprise.entity
{
    public class TurnoConsulta
    {
        private int id;
        private int agendaMedicaId;
        private int? pacienteId;
        private DateTime fechaHoraTurno;
        private bool esSobreturno;
        private EstadoTurnoConsulta estado;
        private DateTime? fechaAsignacion;

        private string medicoNombreCompleto;
        private string consultorioNombre;

        public TurnoConsulta(int id, int agendaMedicaId, int? pacienteId, DateTime fechaHoraTurno, bool esSobreturno, EstadoTurnoConsulta estado, DateTime? fechaAsignacion)
        {
            this.Id = id;
            this.AgendaMedicaId = agendaMedicaId;
            this.PacienteId = pacienteId;
            this.FechaHoraTurno = fechaHoraTurno;
            this.EsSobreturno = esSobreturno;
            this.Estado = estado;
            this.FechaAsignacion = fechaAsignacion;
        }

        public int Id { get => id; set => id = value; }
        public int AgendaMedicaId { get => agendaMedicaId; set => agendaMedicaId = value; }
        public int? PacienteId { get => pacienteId; set => pacienteId = value; }
        public DateTime FechaHoraTurno { get => fechaHoraTurno; set => fechaHoraTurno = value; }
        public bool EsSobreturno { get => esSobreturno; set => esSobreturno = value; }
        public EstadoTurnoConsulta Estado { get => estado; set => estado = value; }
        public DateTime? FechaAsignacion { get => fechaAsignacion; set => fechaAsignacion = value; }
        public string MedicoNombreCompleto { get => medicoNombreCompleto; set => medicoNombreCompleto = value; }
        public string ConsultorioNombre { get => consultorioNombre; set => consultorioNombre = value; }
    }
}