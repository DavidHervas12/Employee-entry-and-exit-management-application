using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AEV7_David_Alberto.Clases;

namespace AEV7_David_Alberto
{
    public partial class FrmPermanencia : Form
    {
        public FrmPermanencia()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();

                if (ValidarDatos())
                {
                    dgvInformacionFichajes.DataSource = Fichaje.ListaFechasFichajes(txtNIF.Text, dtpFechaInicial.Value.Date, dtpFechaFinal.Value.Date);
                    dgvInformacionFichajes.Columns["Fecha"].DataPropertyName = "Fecha";
                    dgvInformacionFichajes.Columns["Hora_Entrada"].DataPropertyName = "Hora_Entrada";
                    dgvInformacionFichajes.Columns["Hora_Salida"].DataPropertyName = "Hora_Salida";
                }
                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }
        }


        #region Validaciones
        private bool ValidarDatos()
        {
            bool ok = true;
            errorProvFichajes.Clear();

            if (!Empleado.ValidaNif(txtNIF))
            {
                ok = false;
                errorProvFichajes.SetError(txtNIF, "El dni no es válido");
            }

            if (Empleado.ComprobarEmpleado(txtNIF.Text))
            {
                ok = false;
                errorProvFichajes.SetError(txtNIF, "DNI del empleado suministrado no existente");
            }

            int resultado = dtpFechaInicial.Value.CompareTo(dtpFechaFinal.Value);
            if (resultado == 1)
            {
                ok = false;
                errorProvFichajes.SetError(dtpFechaInicial, "La fecha inicial no puede ser mayor que la fecha final");
            }

            return ok;
        }
        #endregion
    }
}
