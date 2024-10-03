using System;
using System.Windows.Forms;

namespace MoneyTransfer
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            pbar.Value = 0;         //Inicializamos el objeto
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Establece el tiempo de animacion en pantalla
            pbar.Value += 1;
            if (pbar.Value == 20)
            {
                timer1.Enabled = false;             //Desactiva el timer
                this.Hide();                        //Oculta la pantalla de inicio
                frmLogin form = new frmLogin();     //Instancia del formulario
                form.Show();                        //Llama la instancia 
            }
            else
            {

            }
        }
    }
}
