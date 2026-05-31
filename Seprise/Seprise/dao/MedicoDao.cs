using System;
using System.Collections.Generic;
using System.Data;
using ClubDeportivo.service;
using MySql.Data.MySqlClient;
using Seprise.entity;

namespace Seprise.dao
{
    public class MedicoDao : AbstractDao
    {
        public MedicoDao() : base() { }

        public List<Medico> listarActivos()
        {
            try
            {
                string sql = "SELECT m.id, m.nombre, m.apellido, m.matricula, " +
                             "m.especialidad_id, e.nombre AS especialidad, e.duracion_minima_turno, m.activo " +
                             "FROM medico m " +
                             "INNER JOIN especialidad e ON m.especialidad_id = e.id " +
                             "WHERE m.activo = 1 " +
                             "ORDER BY m.apellido, m.nombre";

                DataTable dataTable = Connection.ejecutarSQL(sql);

                List<Medico> medicos = new List<Medico>();

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Medico medico = new Medico(
                            int.Parse(row["id"].ToString()),
                            row["nombre"].ToString(),
                            row["apellido"].ToString(),
                            row["matricula"].ToString(),
                            int.Parse(row["especialidad_id"].ToString()),
                            row["especialidad"].ToString(),
                            int.Parse(row["duracion_minima_turno"].ToString()),
                            Convert.ToBoolean(row["activo"])
                        );
                        medicos.Add(medico);
                    }
                }

                return medicos;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
