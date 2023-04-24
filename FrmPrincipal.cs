using AEV7_David_Alberto.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEV7_David_Alberto
{
    public partial class FrmPrincipal : Form
    {
        FrmClave frmClave;

        public FrmPrincipal()
        {
            InitializeComponent();
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("d");
        }

        private void timReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            timReloj.Enabled = true;
            timReloj.Interval = 1000;
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                if (Empleado.ComprobarAdministrador(mtbDni))
                {
                    frmClave = new FrmClave();
                    frmClave.Show();

                    if (frmClave != null)
                    {
                        frmClave.Activate();
                    }
                }

                ConexionBD.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No existe conexión a la Base de datos");
            }


        }

        private void mtbdni_TextChanged(object sender, EventArgs e)
        {
            mtbDni.Text = mtbDni.Text.ToUpper();
        }
    }
}
