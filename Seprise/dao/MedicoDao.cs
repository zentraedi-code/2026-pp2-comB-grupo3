using ClubDeportivo.service;
using Seprise.entity;
using System.Data;

namespace Seprise.dao
{
    public class MedicoDao : AbstractDao
    {
        public MedicoDao() : base() { }

        public bool agregar(Medico medico)
        {
            string sql = $"INSERT INTO medico (especialidad_id, matricula, nombre, apellido, importe_consulta, activo) " +
                         $"VALUES ({medico.EspecialidadId}, '{medico.Matricula}', '{medico.Nombre}', " +
                         $"'{medico.Apellido}', {medico.ImporteConsulta}, {(medico.Activo ? 1 : 0)})";
            return Connection.ejecutarComandoSQL(sql) > 0;
        }

        private Medico MapearMedico(DataRow row)
        {
            return new Medico(
                int.Parse(row["id"].ToString()),
                row["matricula"].ToString(),
                row["nombre"].ToString(),
                row["apellido"].ToString(),
                int.Parse(row["especialidad_id"].ToString()),
                row["especialidad_nombre"].ToString(),
                decimal.Parse(row["importe_consulta"].ToString()),
                Convert.ToBoolean(row["activo"]),
                row.Table.Columns.Contains("duracion_minima_turno") && row["duracion_minima_turno"] != DBNull.Value
                    ? int.Parse(row["duracion_minima_turno"].ToString())
                    : 15
            );
        }

        public List<Medico> listarTodos()
        {
            string sql = "SELECT m.id, m.matricula, m.nombre, m.apellido, m.especialidad_id, " +
                         "e.nombre as especialidad_nombre, m.importe_consulta, m.activo " +
                         "FROM medico m JOIN especialidad e ON m.especialidad_id = e.id " +
                         "ORDER BY m.apellido, m.nombre";
            DataTable dt = Connection.ejecutarSQL(sql);
            List<Medico> medicos = new List<Medico>();
            if (dt != null && dt.Rows.Count > 0)
                foreach (DataRow row in dt.Rows)
                    medicos.Add(MapearMedico(row));
            return medicos;
        }

        public List<Medico> listarActivos()
        {
            string sql = "SELECT m.id, m.matricula, m.nombre, m.apellido, m.especialidad_id, " +
                         "e.nombre as especialidad_nombre, m.importe_consulta, m.activo " +
                         "FROM medico m JOIN especialidad e ON m.especialidad_id = e.id " +
                         "WHERE m.activo = 1 " +
                         "ORDER BY m.apellido, m.nombre";
            DataTable dt = Connection.ejecutarSQL(sql);
            List<Medico> medicos = new List<Medico>();
            if (dt != null && dt.Rows.Count > 0)
                foreach (DataRow row in dt.Rows)
                    medicos.Add(MapearMedico(row));
            return medicos;
        }

        public bool modificar(Medico medico)
        {
            string sql = $"UPDATE medico SET " +
                         $"nombre = '{medico.Nombre}', " +
                         $"apellido = '{medico.Apellido}', " +
                         $"especialidad_id = {medico.EspecialidadId}, " +
                         $"importe_consulta = {medico.ImporteConsulta}, " +
                         $"activo = {(medico.Activo ? 1 : 0)} " +
                         $"WHERE id = {medico.Id}";
            return Connection.ejecutarComandoSQL(sql) > 0;
        }

        public bool desactivar(int id)
        {
            string sql = $"UPDATE medico SET activo = 0 WHERE id = {id}";
            return Connection.ejecutarComandoSQL(sql) > 0;
        }
    }
}