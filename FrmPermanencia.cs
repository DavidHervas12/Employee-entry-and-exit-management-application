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

                if (ValidarDatos() && ValidarEmpleadoExistente())
                {
                    int duracionTotal = CargaDataGrid(Fichaje.ListaFechasFichajes(txtNIF.Text, dtpFechaInicial.Value, dtpFechaFinal.Value));
                    txtTotal.Text = duracionTotal.ToString();  //Duración máximo que se almacena en el TextBox gracias al cargadatagrid 
                }
                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }
        }
        /// <summary>
        /// Método que carga los datos en el DataGridView de la lista de fichajes y calcula duración total de la permanencia
        /// </summary>
        /// <param name="lista">Lista de fichajes calculados mediante dos fechas</param>
        /// <returns>Minutos de duración total de los fichajes</returns>
        private int CargaDataGrid(List<Fichaje> lista)
        {
            dgvInformacionFichajes.Rows.Clear();
            int total = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                total += CalculaDuracion(lista[i].Hora_entrada, lista[i].Hora_salida); //Con una variable te aumenta la cantidad de duración total
                dgvInformacionFichajes.Rows.Add(lista[i].Fecha.ToString("dd/MM/yyyy"), lista[i].Hora_entrada, lista[i].Hora_salida,
                    CalculaDuracion(lista[i].Hora_entrada, lista[i].Hora_salida));
            }
            return total;
        }

        /// <summary>
        /// Calcula la duración de la hora de entrada y de salida
        /// </summary>
        /// <param name="he">Hora de entrada</param>
        /// <param name="hs">Hora de salida</param>
        /// <returns>Número de minutos</returns>
        private int CalculaDuracion(DateTime he, DateTime hs)
        {
            TimeSpan ht = hs.Subtract(he);
            return (ht.Hours * 60) + ht.Minutes;
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

            if (txtNIF.Text == "")
            {
                ok = false;
                errorProvFichajes.SetError(txtNIF, "DNI introducido incompleto");
            }

            int resultado = dtpFechaInicial.Value.CompareTo(dtpFechaFinal.Value);
            if (resultado == 1)
            {
                ok = false;
                errorProvFichajes.SetError(dtpFechaInicial, "La fecha inicial no puede ser mayor que la fecha final");
            }

            return ok;
        }

        private bool ValidarEmpleadoExistente()
        {
            bool ok = true;
            errorProvFichajes.Clear();

            if (Empleado.ComprobarEmpleado(txtNIF.Text))
            {
                ok = false;
                errorProvFichajes.SetError(txtNIF, "DNI del empleado suministrado no existente");
            }

            return ok;

            #endregion
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

