using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MoneyTransfer.Datos
{
    internal class Cusuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string apellidoUsuario;
        private string userName;
        private string clave;
        private string cargo;
        private int perfil;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string ApellidoUsuario { get => apellidoUsuario; set => apellidoUsuario = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Perfil { get => perfil; set => perfil = value; }

        public void mostrarUsuario(DataGridView tablaUsuario)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "select * from usuario";
                tablaUsuario.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaUsuario.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch
            {
                MessageBox.Show("No se mostraron los datos de la base de datos");
            }
        }
        public void guardarUsuario(TextBox nombres, TextBox apellidos, TextBox nombre_usuario)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "insert into usuario(nombres, apellidos, nombre_usuario)" + "values('" + nombres.Text + "','" + apellidos.Text + "','" + nombre_usuario.Text + "');";
                MySqlCommand mycomand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mycomand.ExecuteReader();
                MessageBox.Show("Datos Guardados");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();
            }
            catch
            {
                MessageBox.Show("No se mostraron los datos de la base de datos");
            }
        }
        public void seleccionarUsuario(DataGridView tablausuario, TextBox idusuario, TextBox nombres, TextBox apellidos, TextBox nombre_usuario)
        {
            try
            {
                idusuario.Text = tablausuario.CurrentRow.Cells[0].Value.ToString();
                nombres.Text = tablausuario.CurrentRow.Cells[1].Value.ToString();
                apellidos.Text = tablausuario.CurrentRow.Cells[2].Value.ToString();
                nombre_usuario.Text = tablausuario.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No se logro seleccionar");
            }
        }
        public void modificarUsuario(TextBox idusuario, TextBox nombres, TextBox apellidos, TextBox nombre_usuario)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "update usuario set nombres='" + nombres.Text + "', apellidos='" + apellidos.Text + "', nombre_usuario='" + nombre_usuario.Text + "' where idusuario='" + idusuario.Text + "';";
                MySqlCommand mycomand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mycomand.ExecuteReader();
                MessageBox.Show("Se modifico correctamente");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();
            }
            catch
            {
                MessageBox.Show("No se modificaron los datos");
            }
        }
        public void eliminarUsuario(TextBox idusuario)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                string query = "delete from usuario where idusuario='" + idusuario.Text + "';";
                MySqlCommand mycomand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mycomand.ExecuteReader();
                MessageBox.Show("Se elimino correctamente");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();
            }
            catch
            {
                MessageBox.Show("No se eliminaron los datos");
            }
        }

    }
}
