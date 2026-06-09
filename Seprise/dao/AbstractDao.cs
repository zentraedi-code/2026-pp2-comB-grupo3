using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;

namespace ClubDeportivo.service
{
    public class AbstractDao
    {
        private ServicioConexion connection;
        public AbstractDao()
        {
            this.Connection = ServicioConexion.getInstancia();
        }
        protected ServicioConexion Connection { get => connection; set => connection = value; }
    }
}
