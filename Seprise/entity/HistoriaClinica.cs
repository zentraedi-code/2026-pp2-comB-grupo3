using System;

namespace Seprise.entity;
public class HistoriaClinica
    {
        public int Id { get; set; }
        public int TurnoConsultaId { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public string MotivoConsulta { get; set; }
        public string Diagnostico { get; set; }
        public string Indicaciones { get; set; }
        public DateTime FechaCarga { get; set; }
    }