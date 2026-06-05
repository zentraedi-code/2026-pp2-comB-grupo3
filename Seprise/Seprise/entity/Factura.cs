using System;

namespace Seprise.entity
{
    public class Factura
    {
        private int id;
        private int pacienteId;
        private int? turnoConsultaId;
        private int? solicitudEstudioId;
        private decimal importeTotal;
        private string? tipoCobertura;
        private string? estado;
        private DateTime fechaEmision;

        public Factura(int id, int pacienteId, int? turnoConsultaId, int? solicitudEstudioId, decimal importeTotal, string? tipoCobertura, string? estado, DateTime fechaEmision)
        {
            this.Id = id;
            this.PacienteId = pacienteId;
            this.TurnoConsultaId = turnoConsultaId;
            this.SolicitudEstudioId = solicitudEstudioId;
            this.ImporteTotal = importeTotal;
            this.TipoCobertura = tipoCobertura;
            this.Estado = estado;
            this.FechaEmision = fechaEmision;
        }

        public int Id { get => id; set => id = value; }
        public int PacienteId { get => pacienteId; set => pacienteId = value; }
        public int? TurnoConsultaId { get => turnoConsultaId; set => turnoConsultaId = value; }
        public int? SolicitudEstudioId { get => solicitudEstudioId; set => solicitudEstudioId = value; }
        public decimal ImporteTotal { get => importeTotal; set => importeTotal = value; }
        public string? TipoCobertura { get => tipoCobertura; set => tipoCobertura = value; }
        public string? Estado { get => estado; set => estado = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
    }
}
