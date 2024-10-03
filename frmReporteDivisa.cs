﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MoneyTransfer
{
    public partial class frmReporteDivisa : Form
    {
        public frmReporteDivisa()
        {
            InitializeComponent();
        }
        Datos.CConexion conex = new Datos.CConexion();
        private void frmReporteDivisa_Load(object sender, EventArgs e)
        {

        }

        private void btnReporteFecha_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaInicio = dtpFechaInicio.Value.ToString("yyyy-MM-dd");
                string fechaFinal = dtpFechaFinal.Value.ToString("yyyy-MM-dd");
                if (dtpFechaInicio.Value > dtpFechaFinal.Value)
                {
                    MessageBox.Show("La fecha INICIAL no puede ser mayor a la fecha FINAL", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpFechaInicio.Value = dtpFechaFinal.Value;

                }

                string query = "select * from divisa where fecha>='" + fechaInicio + "'and'" + fechaFinal + "';";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conex.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvReporteDivisa.DataSource = dt;
                conex.cerrarConexion();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
