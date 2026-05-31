using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable listarInactivasPorFiltro(DateTime? fecha, int? medicoId)
        {
            try
            {
                string sql = "SELECT a.id, a.fecha, " +
                             "CONCAT(m.apellido, ', ', m.nombre) AS medico, " +
                             "a.hora_desde, a.hora_hasta, a.duracion_turno_minutos, a.sobre_turnos_por_hora " +
                             "FROM agenda_medica a " +
                             "INNER JOIN medico m ON a.medico_id = m.id " +
                             "WHERE a.estado = 'INACTIVA'";

                if (fecha.HasValue)
                    sql += $" AND a.fecha = '{fecha.Value:yyyy-MM-dd}'";

                if (medicoId.HasValue)
                    sql += $" AND a.medico_id = {medicoId.Value}";

                sql += " ORDER BY a.fecha, m.apellido";

                return Connection.ejecutarSQL(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable listarActivasPorFiltro(DateTime? fecha, int? medicoId)
        {
            try
            {
                string sql = "SELECT a.id, a.fecha, " +
                             "CONCAT(m.apellido, ', ', m.nombre) AS medico, " +
                             "a.hora_desde, a.hora_hasta, a.duracion_turno_minutos, a.sobre_turnos_por_hora " +
                             "FROM agenda_medica a " +
                             "INNER JOIN medico m ON a.medico_id = m.id " +
                             "WHERE a.estado = 'ACTIVA'";

                if (fecha.HasValue)
                    sql += $" AND a.fecha = '{fecha.Value:yyyy-MM-dd}'";

                if (medicoId.HasValue)
                    sql += $" AND a.medico_id = {medicoId.Value}";

                sql += " ORDER BY a.fecha, m.apellido";

                return Connection.ejecutarSQL(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public AgendaMedica obtenerPorId(int id)
        {
            try
            {
                string sql = $"SELECT * FROM agenda_medica WHERE id = {id}";
                DataTable dt = Connection.ejecutarSQL(sql);

                if (dt == null || dt.Rows.Count == 0)
                    return null;

                DataRow row = dt.Rows[0];
                AgendaMedica agenda = new AgendaMedica(
                    int.Parse(row["medico_id"].ToString()),
                    int.Parse(row["consultorio_id"].ToString()),
                    Convert.ToDateTime(row["fecha"]),
                    TimeSpan.Parse(row["hora_desde"].ToString()),
                    TimeSpan.Parse(row["hora_hasta"].ToString()),
                    int.Parse(row["duracion_turno_minutos"].ToString()),
                    int.Parse(row["sobre_turnos_por_hora"].ToString()),
                    (EstadoAgendaMedica)Enum.Parse(typeof(EstadoAgendaMedica), row["estado"].ToString())
                );
                agenda.Id = id;
                return agenda;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool confirmarConTurnos(int agendaId)
        {
            try
            {
                AgendaMedica agenda = obtenerPorId(agendaId);
                if (agenda == null)
                    return false;

                string sqlActualizar = $"UPDATE agenda_medica SET estado = '{EstadoAgendaMedica.ACTIVA}' WHERE id = {agendaId}";
                Connection.ejecutarComandoSQL(sqlActualizar);

                DateTime fechaBase = agenda.Fecha.Date;
                TimeSpan duracion = TimeSpan.FromMinutes(agenda.DuracionTurnoMinutos);
                TimeSpan cursor = agenda.HoraDesde;

                int horaActual = (int)agenda.HoraDesde.TotalHours;
                int horaFinal = (int)agenda.HoraHasta.TotalHours;

                for (int h = horaActual; h < horaFinal; h++)
                {
                    TimeSpan inicioHora = TimeSpan.FromHours(h);
                    if (inicioHora >= agenda.HoraDesde && inicioHora < agenda.HoraHasta)
                    {
                        DateTime fechaHoraSobreturno = fechaBase + inicioHora;
                        for (int s = 0; s < agenda.SobreTurnosPorHora; s++)
                        {
                            string sqlSobre = $"INSERT INTO turno_consulta (agenda_medica_id, paciente_id, fecha_hora_turno, es_sobreturno, estado) " +
                                             $"VALUES ({agendaId}, NULL, '{fechaHoraSobreturno:yyyy-MM-dd HH:mm:ss}', 1, 'DISPONIBLE')";
                            Connection.ejecutarComandoSQL(sqlSobre);
                        }
                    }
                }

                while (cursor + duracion <= agenda.HoraHasta)
                {
                    DateTime fechaHoraTurno = fechaBase + cursor;
                    string sqlTurno = $"INSERT INTO turno_consulta (agenda_medica_id, paciente_id, fecha_hora_turno, es_sobreturno, estado) " +
                                     $"VALUES ({agendaId}, NULL, '{fechaHoraTurno:yyyy-MM-dd HH:mm:ss}', 0, 'DISPONIBLE')";
                    Connection.ejecutarComandoSQL(sqlTurno);
                    cursor += duracion;
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool cancelarConTurnos(int agendaId)
        {
            try
            {
                string sqlTurnos = $"DELETE FROM turno_consulta WHERE agenda_medica_id = {agendaId}";
                Connection.ejecutarComandoSQL(sqlTurnos);

                string sqlAgenda = $"UPDATE agenda_medica SET estado = '{EstadoAgendaMedica.CANCELADA}' WHERE id = {agendaId}";
                Connection.ejecutarComandoSQL(sqlAgenda);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool existeSuperposicionPorMedico(int medicoId, DateTime fecha, TimeSpan horaDesde, TimeSpan horaHasta, int? excluirAgendaId = null)
        {
            try
            {
                string sql = $"SELECT COUNT(*) FROM agenda_medica " +
                             $"WHERE medico_id = {medicoId} " +
                             $"AND fecha = '{fecha:yyyy-MM-dd}' " +
                             $"AND hora_desde < '{horaHasta:hh\\:mm\\:ss}' " +
                             $"AND hora_hasta > '{horaDesde:hh\\:mm\\:ss}' " +
                             $"AND estado <> '{EstadoAgendaMedica.CANCELADA}'";

                if (excluirAgendaId.HasValue)
                    sql += $" AND id <> {excluirAgendaId.Value}";

                DataTable dt = Connection.ejecutarSQL(sql);
                return dt != null && dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool existeSuperposicionPorConsultorio(int consultorioId, DateTime fecha, TimeSpan horaDesde, TimeSpan horaHasta, int? excluirAgendaId = null)
        {
            try
            {
                string sql = $"SELECT COUNT(*) FROM agenda_medica " +
                             $"WHERE consultorio_id = {consultorioId} " +
                             $"AND fecha = '{fecha:yyyy-MM-dd}' " +
                             $"AND hora_desde < '{horaHasta:hh\\:mm\\:ss}' " +
                             $"AND hora_hasta > '{horaDesde:hh\\:mm\\:ss}' " +
                             $"AND estado <> '{EstadoAgendaMedica.CANCELADA}'";

                if (excluirAgendaId.HasValue)
                    sql += $" AND id <> {excluirAgendaId.Value}";

                DataTable dt = Connection.ejecutarSQL(sql);
                return dt != null && dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
