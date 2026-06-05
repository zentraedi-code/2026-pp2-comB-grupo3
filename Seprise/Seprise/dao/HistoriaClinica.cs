using System;
using System.Collections.Generic;
using System.Data;
using ClubDeportivo.service;
using Seprise.entity;

namespace Seprise.dao
{
    public class HistoriaClinicaDao : AbstractDao
    {
        public HistoriaClinicaDao() : base() { }

        public bool guardar(HistoriaClinica historia)
        {
            try
            {
                string sql = $"INSERT INTO historia_clinica " +
                             $"(paciente_id, medico_id, turno_consulta_id, fecha_carga, motivo_consulta, diagnostico, indicaciones) " +
                             $"VALUES ({historia.PacienteId}, {historia.MedicoId}, {historia.TurnoConsultaId}, " +
                             $"'{historia.FechaCarga:yyyy-MM-dd HH:mm:ss}', " +
                             $"'{historia.MotivoConsulta}', " +
                             $"'{historia.Diagnostico}', " +
                             $"'{historia.Indicaciones}')";

                int result = Connection.ejecutarComandoSQL(sql);
                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public HistoriaClinica? obtenerPorId(int id)
        {
            try
            {
                string sql = $"SELECT * FROM historia_clinica WHERE id = {id}";
                DataTable dt = Connection.ejecutarSQL(sql);
                if (dt == null || dt.Rows.Count == 0)
                    return null;

                return MapearHistoriaClinica(dt.Rows[0]);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<HistoriaClinica> listarTodos()
        {
            try
            {
                string sql = "SELECT * FROM historia_clinica ORDER BY fecha_carga DESC";
                DataTable dt = Connection.ejecutarSQL(sql);

                List<HistoriaClinica> historias = new List<HistoriaClinica>();
                if (dt == null || dt.Rows.Count == 0)
                    return historias;

                foreach (DataRow row in dt.Rows)
                {
                    historias.Add(MapearHistoriaClinica(row));
                }

                return historias;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<HistoriaClinica> buscarPorPaciente(int pacienteId)
        {
            try
            {
                string sql = $"SELECT * FROM historia_clinica WHERE paciente_id = {pacienteId} ORDER BY fecha_carga DESC";
                DataTable dt = Connection.ejecutarSQL(sql);

                List<HistoriaClinica> historias = new List<HistoriaClinica>();
                if (dt == null || dt.Rows.Count == 0)
                    return historias;

                foreach (DataRow row in dt.Rows)
                {
                    historias.Add(MapearHistoriaClinica(row));
                }

                return historias;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool actualizar(HistoriaClinica historia)
        {
            try
            {
                string sql = $"UPDATE historia_clinica SET " +
                             $"paciente_id = {historia.PacienteId}, " +
                             $"medico_id = {historia.MedicoId}, " +
                             $"turno_consulta_id = {historia.TurnoConsultaId}, " +
                             $"fecha_carga = '{historia.FechaCarga:yyyy-MM-dd HH:mm:ss}', " +
                             $"motivo_consulta = '{historia.MotivoConsulta}', " +
                             $"diagnostico = '{historia.Diagnostico}', " +
                             $"indicaciones = '{historia.Indicaciones}' " +
                             $"WHERE id = {historia.Id}";

                int result = Connection.ejecutarComandoSQL(sql);
                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool eliminar(int id)
        {
            try
            {
                string sql = $"DELETE FROM historia_clinica WHERE id = {id}";
                int result = Connection.ejecutarComandoSQL(sql);
                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private HistoriaClinica MapearHistoriaClinica(DataRow row)
        {
            return new HistoriaClinica
            {
                Id = row.Field<int>("id"),
                PacienteId = row.Field<int>("paciente_id"),
                MedicoId = row.Field<int>("medico_id"),
                TurnoConsultaId = row.Field<int>("turno_consulta_id"),
                FechaCarga = row.Field<DateTime>("fecha_carga"),
                MotivoConsulta = row.Field<string>("motivo_consulta") ?? string.Empty,
                Diagnostico = row.Field<string>("diagnostico") ?? string.Empty,
                Indicaciones = row.Field<string>("indicaciones") ?? string.Empty
            };
        }
    }
}