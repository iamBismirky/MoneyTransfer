using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MoneyTransfer.Datos
{
    internal class CDivisas
    {
        private static int secuencia;
        private static string tipomoneda;
        private static float cantidad;
        private static float tasa;
        private static float totalpesos;
        private static string nombre;
        private static string apellido;
        private static string telefono;
        private static string cedula;
        private static string fecha;

        public int Secuencia { get => secuencia; set => secuencia = value; }
        public string Tipomoneda { get => tipomoneda; set => tipomoneda = value; }
        public float Cantidad { get => cantidad; set => cantidad = value; }
        public float Tasa { get => tasa; set => tasa = value; }
        public float Totalpesos { get => totalpesos; set => totalpesos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Fecha { get => fecha; set => fecha = value; }

        public void mostrarDivisa(DataGridView tablaUsuario)
        {
            try
            {
                CConexion conex = new CConexion();

                string query = "select * from divisa";
                tablaUsuario.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conex.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaUsuario.DataSource = dt;
                conex.cerrarConexion();
            }
            catch
            {
                MessageBox.Show("No se mostraron los datos de la base de datos");
            }
        }

    }

}


