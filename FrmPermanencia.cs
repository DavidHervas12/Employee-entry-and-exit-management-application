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
                    int duracionTotal = CargaDataGrid(Fichaje.ListaFechasFichajes(txtNIF.Text, dtpFechaInicial.Value, dtpFechaFinal.Value));
                    txtTotal.Text = duracionTotal.ToString();
                }
                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }
        }

        private int CargaDataGrid(List<Fichaje> lista)
        {
            dgvInformacionFichajes.Rows.Clear();
            int total = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                total += CalculaDuracion(lista[i].Hora_entrada, lista[i].Hora_salida);
                dgvInformacionFichajes.Rows.Add(lista[i].Fecha.Date, lista[i].Hora_entrada, lista[i].Hora_salida, 
                    CalculaDuracion(lista[i].Hora_entrada, lista[i].Hora_salida));
            }
            return total;
        }

        private int CalculaDuracion(DateTime he, DateTime hs)
        {
            TimeSpan ht = hs.Subtract(he);
            return ht.Minutes;
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
