using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MoneyTransfer.Datos
{
    internal class CEnvio
    {
        private int numeroenvio;
        private int secuencia;
        private string moneda;
        private string destino;
        private float montoenviar;
        private float tarifa;
        private float montorecibir;
        private float totalpagar;
        private string nombre;
        private string apellido;
        private string cedula;
        private string telefono;
        private string beneficiario;
        private string fecha;

        public int Numeroenvio { get => numeroenvio; set => numeroenvio = value; }
        public int Secuencia { get => secuencia; set => secuencia = value; }
        public string Moneda { get => moneda; set => moneda = value; }
        public string Destino { get => destino; set => destino = value; }
        public float Montoenviar { get => montoenviar; set => montoenviar = value; }
        public float Tarifa { get => tarifa; set => tarifa = value; }
        public float Montorecibir { get => montorecibir; set => montorecibir = value; }
        public float Totalpagar { get => totalpagar; set => totalpagar = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Beneficiario { get => beneficiario; set => beneficiario = value; }
        public string Fecha { get => fecha; set => fecha = value; }

        public void mostrarEnvio(DataGridView tablaUsuario)
        {
            try
            {
                CConexion conex = new CConexion();

                string query = "select * from envio";
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


