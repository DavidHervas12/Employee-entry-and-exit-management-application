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
    public partial class FrmClave : Form
    {
        FrmMantenimiento frmMantenimiento;

        public FrmClave()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                if (Empleado.ComprobarClave(txtClave))
                {
                    MessageBox.Show("Accediendo a las funcionalidades de mantenimiento");
                    ConexionBD.CerrarConexion(); //Cerramos conexion de este formulario para no tener conflictos con el otro
                    frmMantenimiento = new FrmMantenimiento();
                    frmMantenimiento.Show();

                    if (frmMantenimiento != null)
                    {
                        frmMantenimiento.Activate();
                    }
                } else
                {
                    MessageBox.Show("La clave introducida del administrador no es correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
