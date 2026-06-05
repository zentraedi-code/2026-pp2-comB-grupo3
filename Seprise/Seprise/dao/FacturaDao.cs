using System;
using System.Data;
using ClubDeportivo.service;
using Seprise.entity;

namespace Seprise.dao
{
    public class FacturaDao : AbstractDao
    {
        public FacturaDao() : base() { }

        public bool agregar(Factura factura)
        {
            try
            {
                string sql = $"INSERT INTO factura (paciente_id, turno_consulta_id, solicitud_estudio_id, importe_total, tipo_cobertura, estado, fecha_emision) " +
                             $"VALUES ({factura.PacienteId}, {(factura.TurnoConsultaId.HasValue ? factura.TurnoConsultaId.Value.ToString() : "NULL")}, " +
                             $"{(factura.SolicitudEstudioId.HasValue ? factura.SolicitudEstudioId.Value.ToString() : "NULL")}, " +
                             $"{factura.ImporteTotal.ToString(System.Globalization.CultureInfo.InvariantCulture)}, '{factura.TipoCobertura}', '{factura.Estado}', '{factura.FechaEmision:yyyy-MM-dd HH:mm:ss}')";

                int result = Connection.ejecutarComandoSQL(sql);
                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable obtenerHonorariosPorMedico(DateTime desde, DateTime hasta, int? medicoId = null)
        {
            try
            {
                // Usar el rango de fechas inclusivo con horas para evitar problemas con timeparts
                string desdeStr = $"{desde:yyyy-MM-dd} 00:00:00";
                string hastaStr = $"{hasta:yyyy-MM-dd} 23:59:59";

                string sql = "SELECT m.id AS medico_id, CONCAT(m.apellido, ', ', m.nombre) AS medico, " +
                             "e.nombre AS especialidad, " +
                             "COUNT(f.id) AS consultas, " +
                             "MAX(m.importe_consulta) AS honorario, " +
                             "SUM(f.importe_total) AS total " +
                             "FROM factura f " +
                             "INNER JOIN turno_consulta tc ON f.turno_consulta_id = tc.id " +
                             "INNER JOIN agenda_medica am ON tc.agenda_medica_id = am.id " +
                             "INNER JOIN medico m ON am.medico_id = m.id " +
                             "INNER JOIN especialidad e ON m.especialidad_id = e.id " +
                             $"WHERE f.estado = 'EMITIDA' AND f.fecha_emision BETWEEN '{desdeStr}' AND '{hastaStr}' ";

                if (medicoId.HasValue && medicoId.Value > 0)
                {
                    sql += $"AND m.id = {medicoId.Value} ";
                }

                sql += "GROUP BY m.id, medico, especialidad ORDER BY medico";

                return Connection.ejecutarSQL(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable obtenerDetalleHonorariosPorMedico(DateTime desde, DateTime hasta, int? medicoId = null)
        {
            try
            {
                string desdeStr = $"{desde:yyyy-MM-dd} 00:00:00";
                string hastaStr = $"{hasta:yyyy-MM-dd} 23:59:59";

                string sql = "SELECT tc.fecha_hora_turno, CONCAT(p.apellido, ', ', p.nombre) AS paciente, " +
                             "p.dni AS dni, 'Consulta clínica' AS concepto, f.importe_total AS honorario " +
                             "FROM factura f " +
                             "INNER JOIN turno_consulta tc ON f.turno_consulta_id = tc.id " +
                             "INNER JOIN paciente p ON f.paciente_id = p.id " +
                             "INNER JOIN agenda_medica am ON tc.agenda_medica_id = am.id " +
                             "INNER JOIN medico m ON am.medico_id = m.id " +
                             "WHERE f.estado = 'EMITIDA' AND f.fecha_emision BETWEEN '" + desdeStr + "' AND '" + hastaStr + "' ";

                if (medicoId.HasValue && medicoId.Value > 0)
                {
                    sql += $"AND m.id = {medicoId.Value} ";
                }

                sql += "ORDER BY tc.fecha_hora_turno";

                return Connection.ejecutarSQL(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int contarFacturasEmitidas(DateTime desde, DateTime hasta)
        {
            try
            {
                string desdeStr = $"{desde:yyyy-MM-dd} 00:00:00";
                string hastaStr = $"{hasta:yyyy-MM-dd} 23:59:59";
                string sql = $"SELECT COUNT(*) AS cnt FROM factura WHERE estado = 'EMITIDA' AND fecha_emision BETWEEN '{desdeStr}' AND '{hastaStr}'";
                var dt = Connection.ejecutarSQL(sql);
                if (dt != null && dt.Rows.Count > 0)
                    return Convert.ToInt32(dt.Rows[0]["cnt"]);
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int contarFacturasEmitidasPorMedico(DateTime desde, DateTime hasta, int medicoId)
        {
            try
            {
                string desdeStr = $"{desde:yyyy-MM-dd} 00:00:00";
                string hastaStr = $"{hasta:yyyy-MM-dd} 23:59:59";
                string sql = "SELECT COUNT(f.id) AS cnt " +
                             "FROM factura f " +
                             "INNER JOIN turno_consulta tc ON f.turno_consulta_id = tc.id " +
                             "INNER JOIN agenda_medica am ON tc.agenda_medica_id = am.id " +
                             $"WHERE f.estado = 'EMITIDA' AND f.fecha_emision BETWEEN '{desdeStr}' AND '{hastaStr}' AND am.medico_id = {medicoId}";

                var dt = Connection.ejecutarSQL(sql);
                if (dt != null && dt.Rows.Count > 0)
                    return Convert.ToInt32(dt.Rows[0]["cnt"]);
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool eliminarFacturasEmitidasPorMedico(DateTime desde, DateTime hasta, int medicoId)
        {
            try
            {
                string desdeStr = $"{desde:yyyy-MM-dd} 00:00:00";
                string hastaStr = $"{hasta:yyyy-MM-dd} 23:59:59";
                string sql = "DELETE f FROM factura f " +
                             "INNER JOIN turno_consulta tc ON f.turno_consulta_id = tc.id " +
                             "INNER JOIN agenda_medica am ON tc.agenda_medica_id = am.id " +
                             $"WHERE f.estado = 'EMITIDA' AND f.fecha_emision BETWEEN '{desdeStr}' AND '{hastaStr}' AND am.medico_id = {medicoId}";

                int result = Connection.ejecutarComandoSQL(sql);
                return result >= 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
