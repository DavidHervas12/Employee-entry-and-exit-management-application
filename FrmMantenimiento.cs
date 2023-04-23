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
    public partial class FrmMantenimiento : Form
    {
        public FrmMantenimiento()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    Empleado emp = new Empleado();
                    emp.Nif = txtNIF.Text;
                    emp.Nombre = txtNombre.Text;
                    emp.Apellidos = txtApellidos.Text;
                    emp.Administrador = chkAdministrador.Checked;
                    emp.Contrasenya = txtContrasenya.Text;

                    if (Empleado.ComprobarEmpleado(emp))
                    {
                        MessageBox.Show("El NIF del empleado introducido ya existe");
                    } 
                    else
                    {
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

                    // Cerramos la conexion a la base de datos
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

        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {
            CargaListaEmpleados(); //Cargamos la lista de empleados cuando abrimos el formulario
        }
    }
}
