using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;

namespace ClubDeportivo.service
{
    public class ServicioConexion // la clase debe ser PUBLICA
    {
        // declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private MySqlConnection sqlCon;
        private static ServicioConexion instancia = null;
        private ServicioConexion()
        {
            bool correcto = false;
            int mensaje;
            // creamos las variables para recibir los datos desde el teclado
            string T_servidor = "localhost";
            string T_puerto = "3306";
            string T_usuario = "root";
            string T_clave = ""; // se antepuso la T para indicar

            while (correcto != true)
            {
                // Armamos los cuadros de dialogo para el ingreso de datos
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese servidor", "DATOS DE INSTALACIÓN MySQL", T_servidor);
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese puerto", "DATOS DE INSTALACIÓN MySQL", T_puerto);
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese usuario", "DATOS DE INSTALACIÓN MySQL", T_usuario);
                T_clave = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese clave", "DATOS DE INSTALACIÓN MySQL", T_clave);
                /*
                ________________________________________________________
                ________________
                * controlamos que los datos ingresados para acceder a
                MySQL sean correctos
                *
                ________________________________________________________
                __________________ */
                mensaje = (int)MessageBox.Show("su ingreso: SERVIDOR = " +
                T_servidor + " PUERTO= " + T_puerto + " USUARIO: " +
                T_usuario + " CLAVE: " + T_clave,
                "AVISO DEL SISTEMA", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (mensaje != 6) // el valor 6 corresponde al SI
                {
                    MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }
            }

            //baseDatos = "club";
            //servidor = "localhost";
            //puerto = "3306";
            //usuario = "root";
            //clave = "";

            this.baseDatos = "clinica_seprise";
            this.servidor = T_servidor; // "localhost";
            this.puerto = T_puerto; //"3306";
            this.usuario = T_usuario; // "root";
            this.clave = T_clave; // "";
        }

        public MySqlConnection CrearConexion()
        {

            sqlCon = new MySqlConnection();

            try
            {
                sqlCon.ConnectionString = "datasource=" + servidor +
                ";port=" + puerto +
                ";username=" + usuario +
                ";password=" + clave +
                ";Database=" + baseDatos;
                sqlCon.Open();

            }
            catch (Exception e)
            {
                sqlCon = null;
                throw;
            }

            return sqlCon;
        }
        public void cerrarConexion()
        {
            if(sqlCon!=null && sqlCon.State==ConnectionState.Open)
                sqlCon.Close();
        }

        public static ServicioConexion getInstancia()
        {
            if (instancia == null)
            {
                instancia = new ServicioConexion();
                instancia.CrearConexion();
            }
            return instancia;
        }

        public DataTable ejecutar(MySqlCommand comando)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            comando.Connection = sqlCon;
            // comando.CommandType = CommandType.Text;
            comando.CommandType = CommandType.StoredProcedure;
            resultado = comando.ExecuteReader();
            tabla.Load(resultado);
            return tabla;   
        }

        public DataTable ejecutarSQL(string sql)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlCommand comando = new MySqlCommand(sql, sqlCon);
            comando.CommandType = CommandType.Text;
            resultado = comando.ExecuteReader();
            tabla.Load(resultado);
            return tabla;
        }

        public int ejecutarComandoSQL(string sql)
        {
            MySqlCommand comando = new MySqlCommand(sql, sqlCon);
            comando.CommandType = CommandType.Text;
            return comando.ExecuteNonQuery();
        }


    }
}

