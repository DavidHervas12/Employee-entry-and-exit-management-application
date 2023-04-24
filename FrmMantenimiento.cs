using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AEV7_David_Alberto.Clases;

namespace AEV7_David_Alberto
{
    public partial class FrmMantenimiento : Form
    {
        #region Eventos
        public FrmMantenimiento()
        {
            InitializeComponent();
        }

        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {
            CargaListaEmpleados(); //Cargamos la lista de empleados cuando abrimos el formulario
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                   
                    if (ValidaNifErrorProv(txtNIF))
                    {
                        Empleado emp = new Empleado(txtNIF.Text, txtNombre.Text, txtApellidos.Text,
                        chkAdministrador.Checked, txtContrasenya.Text);
                        resultado = emp.AgregarEmpleado(emp);
                    } 

                    if (resultado > 0)
                    {
                        txtNIF.Clear();
                        txtNombre.Clear();
                        txtApellidos.Clear();
                        chkAdministrador = null;
                        txtContrasenya.Clear();
                    }

                    ConexionBD.CerrarConexion();
                    CargaListaEmpleados();
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            try
            {
                if (ConexionBD.Conexion != null)
                {

                    DialogResult confirmacion = MessageBox.Show("Borrado de registro seleccionado. ¿Continuar?",
                                                "Eliminación", MessageBoxButtons.YesNo);

                    if (confirmacion == DialogResult.Yes)
                    {
                        if (ConexionBD.Conexion != null)
                        {
                            ConexionBD.AbrirConexion();
                            resultado = Empleado.EliminaEmpleado(txtNIF);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                        }
                        // Cierro la conexión
                        ConexionBD.CerrarConexion();
                        CargaListaEmpleados();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }


        }
        #endregion
        private void CargaListaEmpleados()
        {
            string seleccion = "Select * from empleados";
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                dgvEmpleados.DataSource = Empleado.BuscarEmpleado(seleccion);
                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }
        }

        #region Validaciones

        private bool ValidaNifErrorProv(TextBox dni)
        {
            bool ok = true;
            if (!Empleado.ValidaNif(dni))
            {
                ok = false;
                errorProv.SetError(dni, "El dni no es válido");
            }
            if (!Empleado.ComprobarEmpleado(dni))
            {
                ok = false;
                errorProv.SetError(dni, "El DNI del empleado introducido ya existe");
            }

            return ok;
        }
        #endregion

        private void chkAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasenya.Enabled = chkAdministrador.Checked;
            txtContrasenya.Clear();
        }


    }
}
