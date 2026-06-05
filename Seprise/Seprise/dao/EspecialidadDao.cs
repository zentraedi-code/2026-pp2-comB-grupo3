﻿using System;
using System.Collections.Generic;
using System.Data;
using ClubDeportivo.service;
using Seprise.entity;

namespace Seprise.dao
{
    public class EspecialidadDao : AbstractDao
    {
        public EspecialidadDao() : base() { }

        public List<Especialidad> listarActivas()
        {
            try
            {
                string sql = "SELECT id, nombre, descripcion, duracion_minima_turno, activo " +
                             "FROM especialidad " +
                             "WHERE activo = 1 " +
                             "ORDER BY nombre";

                DataTable dataTable = Connection.ejecutarSQL(sql);

                List<Especialidad> especialidades = new List<Especialidad>();

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Especialidad esp = new Especialidad(
                            int.Parse(row["id"].ToString()),
                            row["nombre"].ToString(),
                            row["descripcion"] != DBNull.Value ? row["descripcion"].ToString() : string.Empty,
                            int.Parse(row["duracion_minima_turno"].ToString()),
                            Convert.ToBoolean(row["activo"])
                        );
                        especialidades.Add(esp);
                    }
                }

                return especialidades;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}