using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubDeportivo.service;
using MySql.Data.MySqlClient;
using Seprise.entity;

namespace Seprise.dao
{
    public class PacienteDao : AbstractDao
    {
        public PacienteDao() : base() { }

        public bool agregar(Paciente paciente)
        {
            try
            {
                string sql = $"INSERT INTO paciente (dni, nombre, apellido, fecha_nacimiento, telefono, obra_social, activo) " +
                             $"VALUES ('{paciente.Dni}', '{paciente.Nombre}', '{paciente.Apellido}', " +
                             $"'{paciente.FechaNacimiento:yyyy-MM-dd}', " +
                             $"{(paciente.Telefono != null ? $"'{paciente.Telefono}'" : "NULL")}, " +
                             $"{(paciente.ObraSocial != null ? $"'{paciente.ObraSocial}'" : "NULL")}, " +
                             $"{(paciente.Activo ? 1 : 0)})";

                int result = Connection.ejecutarComandoSQL(sql);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Paciente buscar(string dni)
        {
            try
            {
                string sql = $"SELECT id, dni, nombre, apellido, fecha_nacimiento, telefono, obra_social, activo " +
                             $"FROM paciente WHERE dni = '{dni}'";

                DataTable dataTable = Connection.ejecutarSQL(sql);

                if (dataTable == null || dataTable.Rows.Count <= 0)
                {
                    return null;
                }

                DataRow row = dataTable.Rows[0];

                Paciente paciente = new Paciente(
                    int.Parse(row["id"].ToString()),
                    row["dni"].ToString(),
                    row["nombre"].ToString(),
                    row["apellido"].ToString(),
                    Convert.ToDateTime(row["fecha_nacimiento"]),
                    row["telefono"] != DBNull.Value ? row["telefono"].ToString() : null,
                    row["obra_social"] != DBNull.Value ? row["obra_social"].ToString() : null,
                    Convert.ToBoolean(row["activo"])
                );

                return paciente;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Paciente> listarTodos()
        {
            try
            {
                string sql = "SELECT id, dni, nombre, apellido, fecha_nacimiento, telefono, obra_social, activo " +
                             "FROM paciente ORDER BY apellido, nombre";

                DataTable dataTable = Connection.ejecutarSQL(sql);

                List<Paciente> pacientes = new List<Paciente>();

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Paciente paciente = new Paciente(
                            int.Parse(row["id"].ToString()),
                            row["dni"].ToString(),
                            row["nombre"].ToString(),
                            row["apellido"].ToString(),
                            Convert.ToDateTime(row["fecha_nacimiento"]),
                            row["telefono"] != DBNull.Value ? row["telefono"].ToString() : null,
                            row["obra_social"] != DBNull.Value ? row["obra_social"].ToString() : null,
                            Convert.ToBoolean(row["activo"])
                        );
                        pacientes.Add(paciente);
                    }
                }

                return pacientes;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool modificar(Paciente paciente)
        {
            try
            {
                string sql = $"UPDATE paciente SET " +
                             $"dni = '{paciente.Dni}', " +
                             $"nombre = '{paciente.Nombre}', " +
                             $"apellido = '{paciente.Apellido}', " +
                             $"fecha_nacimiento = '{paciente.FechaNacimiento:yyyy-MM-dd}', " +
                             $"telefono = {(paciente.Telefono != null ? $"'{paciente.Telefono}'" : "NULL")}, " +
                             $"obra_social = {(paciente.ObraSocial != null ? $"'{paciente.ObraSocial}'" : "NULL")}, " +
                             $"activo = {(paciente.Activo ? 1 : 0)} " +
                             $"WHERE id = {paciente.Id}";

                int result = Connection.ejecutarComandoSQL(sql);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool desactivar(int id)
        {
            try
            {
                string sql = $"UPDATE paciente SET activo = 0 WHERE id = {id}";
                int result = Connection.ejecutarComandoSQL(sql);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Paciente> buscarFiltrado(string dni, string nomApe)
        {
            try
            {
                string sql = "SELECT id, dni, nombre, apellido, fecha_nacimiento, telefono, obra_social, activo " +
                             "FROM paciente WHERE activo = 1";

                if (!string.IsNullOrEmpty(dni))
                    sql += $" AND dni = '{dni}'";

                if (!string.IsNullOrEmpty(nomApe))
                    sql += $" AND apellido LIKE '%{nomApe}%'";

                sql += " ORDER BY apellido, nombre";

                DataTable dataTable = Connection.ejecutarSQL(sql);
                List<Paciente> pacientes = new List<Paciente>();

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        pacientes.Add(new Paciente(
                            int.Parse(row["id"].ToString()),
                            row["dni"].ToString(),
                            row["nombre"].ToString(),
                            row["apellido"].ToString(),
                            Convert.ToDateTime(row["fecha_nacimiento"]),
                            row["telefono"] != DBNull.Value ? row["telefono"].ToString() : null,
                            row["obra_social"] != DBNull.Value ? row["obra_social"].ToString() : null,
                            Convert.ToBoolean(row["activo"])
                        ));
                    }
                }

                return pacientes;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
