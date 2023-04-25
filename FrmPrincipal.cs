using AEV7_David_Alberto.Clases;
using System;
using System.Net;
using System.Windows.Forms;

namespace AEV7_David_Alberto
{
    public partial class FrmPrincipal : Form
    {
        FrmClave frmClave;

        private static string nif; //Hago un atributo nif para comunicarme con otro formulario
        public static string NIF { get { return nif; } set { nif = value; } }

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

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    if (!Empleado.ComprobarEmpleado(mtbDni.Text.Substring(0, 8) + mtbDni.Text[9]))
                    {
                        Fichaje f = new Fichaje(mtbDni.Text.Substring(0, 8) + mtbDni.Text[9]);
                        resultado = f.DarEntrada(f);


                        if (resultado > 0)
                        {
                            mtbDni.Clear();
                        }

                        ConexionBD.CerrarConexion();
                    }
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

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConexionBD.Conexion != null)
                {
                    if (Empleado.ValidaNif(mtbDni))
                    {
                        if (Empleado.ComprobarAdministrador(mtbDni))
                        {
                            frmClave = new FrmClave();
                            frmClave.Show();

                            if (frmClave != null)
                            {
                                frmClave.Activate();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El dni introducido no es válido");
                    }

                    ConexionBD.CerrarConexion();
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

        private void mtbdni_TextChanged(object sender, EventArgs e)
        {
            mtbDni.Text = mtbDni.Text.ToUpper();
        }


    }
}
