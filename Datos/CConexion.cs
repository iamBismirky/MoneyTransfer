using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MoneyTransfer.Datos
{
    internal class CConexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "moneydb";
        static string usuario = "root";
        static string password = "11271995";
        static string puerto = "3306";

        string cadenaconexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection establecerConexion()
        {
            try
            {
                if (conex.State == System.Data.ConnectionState.Open)
                {
                    conex.Close();
                }
                conex.ConnectionString = cadenaconexion;
                conex.Open();
                //MessageBox.Show("Conectado a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "No se conecto a la base de datos");
            }
            return conex;
        }
        public void cerrarConexion()
        {
            conex.Close();
        }
    }
}
