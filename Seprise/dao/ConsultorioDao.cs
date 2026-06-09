﻿using System;
using System.Collections.Generic;
using System.Data;
using ClubDeportivo.service;
using Seprise.entity;

namespace Seprise.dao
{
    public class ConsultorioDao : AbstractDao
    {
        public ConsultorioDao() : base() { }

        public List<Consultorio> listarActivos()
        {
            try
            {
                string sql = "SELECT id, nombre, activo " +
                             "FROM consultorio " +
                             "WHERE activo = 1 " +
                             "ORDER BY nombre";

                DataTable dataTable = Connection.ejecutarSQL(sql);

                List<Consultorio> consultorios = new List<Consultorio>();

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Consultorio consultorio = new Consultorio(
                            int.Parse(row["id"].ToString()),
                            row["nombre"].ToString(),
                            Convert.ToBoolean(row["activo"])
                        );
                        consultorios.Add(consultorio);
                    }
                }

                return consultorios;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}