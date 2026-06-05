﻿using System;
using System.Collections.Generic;
using System.Data;
using ClubDeportivo.service;
using Seprise.entity;
using static Seprise.entity.EstadoTurnoConsulta;

namespace Seprise.dao
{
    public class TurnoConsultaDao : AbstractDao
    {
        public TurnoConsultaDao() : base() { }

        public List<TurnoConsulta> buscarDisponiblesPorProfesionalYFecha(int medicoId, DateTime fecha)
        {
            try
            {
                string sql = "SELECT tc.id, tc.agenda_medica_id, tc.paciente_id, tc.fecha_hora_turno, " +
                             "tc.es_sobreturno, tc.estado, tc.fecha_asignacion, " +
                             "CONCAT(m.apellido, ', ', m.nombre) AS medico, " +
                             "c.nombre AS consultorio " +
                             "FROM turno_consulta tc " +
                             "INNER JOIN agenda_medica am ON tc.agenda_medica_id = am.id " +
                             "INNER JOIN medico m ON am.medico_id = m.id " +
                             "INNER JOIN consultorio c ON am.consultorio_id = c.id " +
                             $"WHERE m.id = {medicoId} " +
                             $"AND DATE(tc.fecha_hora_turno) = '{fecha:yyyy-MM-dd}' " +
                             "AND tc.estado = 'DISPONIBLE' " +
                             "ORDER BY tc.fecha_hora_turno";

                return mapearResultado(Connection.ejecutarSQL(sql));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TurnoConsulta> buscarPrimeraDisponiblePorProfesional(int medicoId)
        {
            try
            {
                string sql = "SELECT tc.id, tc.agenda_medica_id, tc.paciente_id, tc.fecha_hora_turno, " +
                             "tc.es_sobreturno, tc.estado, tc.fecha_asignacion, " +
                             "CONCAT(m.apellido, ', ', m.nombre) AS medico, " +
                             "c.nombre AS consultorio " +
                             "FROM turno_consulta tc " +
                             "INNER JOIN agenda_medica am ON tc.agenda_medica_id = am.id " +
                             "INNER JOIN medico m ON am.medico_id = m.id " +
                             "INNER JOIN consultorio c ON am.consultorio_id = c.id " +
                             $"WHERE m.id = {medicoId} " +
                             "AND tc.estado = 'DISPONIBLE' " +
                             "AND DATE(tc.fecha_hora_turno) = (" +
                             "    SELECT DATE(tc2.fecha_hora_turno) " +
                             "    FROM turno_consulta tc2 " +
                             "    INNER JOIN agenda_medica am2 ON tc2.agenda_medica_id = am2.id " +
                             $"   WHERE am2.medico_id = {medicoId} " +
                             "    AND tc2.estado = 'DISPONIBLE' " +
                             "    AND tc2.fecha_hora_turno >= NOW() " +
                             "    ORDER BY tc2.fecha_hora_turno " +
                             "    LIMIT 1" +
                             ") " +
                             "ORDER BY tc.fecha_hora_turno";

                return mapearResultado(Connection.ejecutarSQL(sql));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool reservar(int turnoConsultaId, int pacienteId)
        {
            try
            {
                string sql = $"UPDATE turno_consulta " +
                             $"SET estado = '{EstadoTurnoConsulta.RESERVADO}', paciente_id = {pacienteId}, fecha_asignacion = NOW() " +
                             $"WHERE id = {turnoConsultaId} AND estado = '{EstadoTurnoConsulta.DISPONIBLE}'";

                int resultado = Connection.ejecutarComandoSQL(sql);
                return resultado > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable buscarReservadosPorPaciente(int pacienteId, DateTime? fecha)
        {
            try
            {
                string sql = "SELECT tc.id, tc.fecha_hora_turno, " +
                             "CONCAT(m.apellido, ', ', m.nombre) AS medico, " +
                             "c.nombre AS consultorio, tc.es_sobreturno, tc.estado " +
                             "FROM turno_consulta tc " +
                             "INNER JOIN agenda_medica am ON tc.agenda_medica_id = am.id " +
                             "INNER JOIN medico m ON am.medico_id = m.id " +
                             "INNER JOIN consultorio c ON am.consultorio_id = c.id " +
                             $"WHERE tc.paciente_id = {pacienteId} " +
                             $"AND tc.estado = '{EstadoTurnoConsulta.RESERVADO}'";

                if (fecha.HasValue)
                    sql += $" AND DATE(tc.fecha_hora_turno) = '{fecha.Value:yyyy-MM-dd}'";

                sql += " ORDER BY tc.fecha_hora_turno";

                return Connection.ejecutarSQL(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool cancelarReserva(int turnoConsultaId)
        {
            try
            {
                string sql = $"UPDATE turno_consulta " +
                             $"SET estado = '{EstadoTurnoConsulta.DISPONIBLE}', paciente_id = NULL, fecha_asignacion = NULL " +
                             $"WHERE id = {turnoConsultaId} AND estado = '{EstadoTurnoConsulta.RESERVADO}'";

                int resultado = Connection.ejecutarComandoSQL(sql);
                return resultado > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public System.Data.DataTable buscarTurnosPorPacienteEnFecha(int pacienteId, DateTime fecha)
        {
            try
            {
                string fechaStr = fecha.ToString("yyyy-MM-dd");
                string sql = "SELECT tc.id, tc.fecha_hora_turno, " +
                             "CONCAT(m.apellido, ', ', m.nombre) AS medico, " +
                             "c.nombre AS consultorio, e.nombre AS especialidad, tc.estado, p.dni AS dni, " +
                             "COALESCE(m.importe_consulta, 0) AS importe_consulta " +
                             "FROM turno_consulta tc " +
                             "INNER JOIN agenda_medica am ON tc.agenda_medica_id = am.id " +
                             "INNER JOIN medico m ON am.medico_id = m.id " +
                             "INNER JOIN consultorio c ON am.consultorio_id = c.id " +
                             "LEFT JOIN especialidad e ON m.especialidad_id = e.id " +
                             "LEFT JOIN paciente p ON tc.paciente_id = p.id " +
                             $"WHERE tc.paciente_id = {pacienteId} AND DATE(tc.fecha_hora_turno) = '{fechaStr}' " +
                             $"AND tc.estado IN ('{EstadoTurnoConsulta.RESERVADO}', '{EstadoTurnoConsulta.RECEPCIONADO}') " +
                             "ORDER BY tc.fecha_hora_turno";

                return Connection.ejecutarSQL(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public System.Data.DataTable buscarRecepcionados()
        {
            try
            {
                string sql = "SELECT tc.id, tc.paciente_id, CONCAT(p.apellido, ', ', p.nombre) AS paciente, p.dni AS dni, " +
                             "CONCAT(m.apellido, ', ', m.nombre) AS medico, COALESCE(m.importe_consulta,0) AS importe_consulta, tc.fecha_hora_turno " +
                             "FROM turno_consulta tc " +
                             "INNER JOIN agenda_medica am ON tc.agenda_medica_id = am.id " +
                             "INNER JOIN medico m ON am.medico_id = m.id " +
                             "INNER JOIN paciente p ON tc.paciente_id = p.id " +
                             $"WHERE tc.estado = '{EstadoTurnoConsulta.RECEPCIONADO}' " +
                             "ORDER BY tc.fecha_hora_turno";

                return Connection.ejecutarSQL(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

       public DataTable buscarRecepcionadosPorPaciente(int pacienteId, string? parametroExtra = null)
        {
            try
            {
                // Añadimos el JOIN con médico y especialidad para traer la columna que C# extrae con row["especialidad"]
                string sql = @"
                    SELECT 
                        t.id, 
                        CONCAT(m.apellido, ', ', m.nombre) AS medico, 
                        e.nombre AS especialidad, 
                        m.importe_consulta AS importe_consulta
                    FROM turno_consulta t
                    INNER JOIN agenda_medica a ON t.agenda_medica_id = a.id
                    INNER JOIN medico m ON a.medico_id = m.id
                    INNER JOIN especialidad e ON m.especialidad_id = e.id
                    WHERE t.paciente_id = " + pacienteId + " AND t.estado = 'RECEPCIONADO'";

                // Reemplaza esto por el método de conexión que uses en ese DAO
                return Connection.ejecutarSQL(sql); 
            }
            catch (Exception ex)
            {
                throw;
            }
        } 

        public bool confirmarAsistencia(int turnoId)
        {
            try
            {
                string sql = $"UPDATE turno_consulta SET estado = '{EstadoTurnoConsulta.RECEPCIONADO}' " +
                             $"WHERE id = {turnoId} AND estado = '{EstadoTurnoConsulta.RESERVADO}'";

                int res = Connection.ejecutarComandoSQL(sql);
                return res > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool atenderTurno(int turnoId)
        {
            try
            {
                string sql = $"UPDATE turno_consulta SET estado = '{EstadoTurnoConsulta.ATENDIDO}' " +
                             $"WHERE id = {turnoId} AND (estado = '{EstadoTurnoConsulta.RECEPCIONADO}' OR estado = '{EstadoTurnoConsulta.RESERVADO}')";

                int res = Connection.ejecutarComandoSQL(sql);
                return res > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<TurnoConsulta> mapearResultado(DataTable dataTable)
        {
            List<TurnoConsulta> turnos = new List<TurnoConsulta>();

            if (dataTable == null || dataTable.Rows.Count == 0)
                return turnos;

            foreach (DataRow row in dataTable.Rows)
            {
                TurnoConsulta turno = new TurnoConsulta(
                    int.Parse(row["id"].ToString()),
                    int.Parse(row["agenda_medica_id"].ToString()),
                    row["paciente_id"] != DBNull.Value ? (int?)int.Parse(row["paciente_id"].ToString()) : null,
                    Convert.ToDateTime(row["fecha_hora_turno"]),
                    Convert.ToBoolean(row["es_sobreturno"]),
                    (EstadoTurnoConsulta)Enum.Parse(typeof(EstadoTurnoConsulta), row["estado"].ToString()),
                    row["fecha_asignacion"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["fecha_asignacion"]) : null
                );
                turno.MedicoNombreCompleto = row["medico"].ToString();
                turno.ConsultorioNombre = row["consultorio"].ToString();
                turnos.Add(turno);
            }

            return turnos;
        }
    }
}