using System;
using ClubDeportivo.service;
using Seprise.entity;

namespace Seprise.dao
{
    public class AgendaMedicaDao : AbstractDao
    {
        public AgendaMedicaDao() : base() { }

        public bool agregar(AgendaMedica agenda)
        {
            try
            {
                string sql = $"INSERT INTO agenda_medica (medico_id, consultorio_id, fecha, hora_desde, hora_hasta, duracion_turno_minutos, sobre_turnos_por_hora, estado) " +
                             $"VALUES ({agenda.MedicoId}, {agenda.ConsultorioId}, " +
                             $"'{agenda.Fecha:yyyy-MM-dd}', " +
                             $"'{agenda.HoraDesde:hh\\:mm\\:ss}', " +
                             $"'{agenda.HoraHasta:hh\\:mm\\:ss}', " +
                             $"{agenda.DuracionTurnoMinutos}, " +
                             $"{agenda.SobreTurnosPorHora}, " +
                             $"'{agenda.Estado}')";

                int result = Connection.ejecutarComandoSQL(sql);
                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
