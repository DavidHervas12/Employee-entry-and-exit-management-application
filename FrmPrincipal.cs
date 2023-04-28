using AEV7_David_Alberto.Clases;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Windows.Forms;

namespace AEV7_David_Alberto
{
    public partial class FrmPrincipal : Form
    {
        FrmClave frmClave;
        FrmPermanencia frmPermanencia;

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
            pnlEntrada.Visible = false;

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            
            if (ValidarNIFBlanco())
            {
                try
                {
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();

                        if (Empleado.ValidaNif(mtbDni))
                        {
                            if (!Empleado.ComprobarEmpleado(mtbDni.Text.Substring(0, 8) + mtbDni.Text[9]))
                            {
                                if (Fichaje.ComprobarEntradaFichaje(mtbDni))
                                {
                                    MessageBox.Show("Ya está dado de entrada este fichaje", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    Fichaje f = new Fichaje(mtbDni.Text.Substring(0, 8) + mtbDni.Text[9]); //Instanciamos un objeto Fichaje para ponerlo en la tabla
                                    resultado = f.DarEntrada(f);
                                    Empleado emp = Empleado.BuscarEmpleado(mtbDni.Text.Substring(0, 8) + mtbDni.Text[9]); //Almacenas empleado con el nif correspondiente

                                    pbLogo.Visible = false;
                                    pnlEntrada.Visible = true;
                                    txtInfo.Text = $"Entrada Realizada\r\nNombre:{emp.Nombre} -- Apellido:{emp.Apellidos}"; //utilizamos el retorno de carro \r

                                }
                                if (resultado > 0)
                                {
                                    mtbDni.Clear();
                                }

                                ConexionBD.CerrarConexion();
                            }
                            else
                            {
                                MessageBox.Show("El empleado no está en la base de datos por lo tanto, no se puede realizar el fichaje", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El DNI introducido no es correcto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            if (ValidarNIFBlanco())
            {
                try
                {
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();

                        if (Empleado.ValidaNif(mtbDni))
                        {
                            if (!Empleado.ComprobarEmpleado(mtbDni.Text.Substring(0, 8) + mtbDni.Text[9]))
                            {
                                if (Fichaje.ComprobarEntradaFichaje(mtbDni))
                                {
                                    Fichaje f = new Fichaje(mtbDni.Text.Substring(0, 8) + mtbDni.Text[9]); //Instanciamos un objeto Fichaje para ponerlo en la tabla
                                    f.Hora_salida = DateTime.Now;
                                    f.Finalizado = true;
                                    Empleado empl = Empleado.BuscarEmpleado(mtbDni.Text.Substring(0, 8) + mtbDni.Text[9]); //Almacenas empleado con el nif correspondiente

                                    pbLogo.Visible = false;
                                    pnlEntrada.Visible = true;
                                    resultado = f.DarSalida(f); //Damos de salida el fichaje ya que lo hemos colocado finalizado a true.
                                    txtInfo.Text = "Salida Realizada\r\n\r\nNombre: " + empl.Nombre + " Apellidos: " + empl.Apellidos;
                                }
                                else
                                {
                                    MessageBox.Show("El empleado no esta dado de entrada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                if (resultado > 0)
                                {
                                    mtbDni.Clear();
                                }

                                ConexionBD.CerrarConexion();
                            }
                            else
                            {
                                MessageBox.Show("El empleado no está en la base de datos por lo tanto, no se puede realizar el fichaje", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("NIF introducido incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void btnPresencia_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    pbLogo.Visible = false;
                    pnlEntrada.Visible = true;

                    txtInfo.Text = "Empleados trabajando:";
                    List<Fichaje> actuales = Fichaje.VerFichajesTotales("SELECT * FROM fichajes WHERE finalizado=0");

                    foreach (Fichaje f in actuales)
                    {
                        Empleado emp = Empleado.BuscarEmpleado(f.NifEmpleado);
                        txtInfo.Text += $"\r\nDNI:{emp.Nif} -- {emp.Nombre} -- {emp.Apellidos}";
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

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            if (ValidarNIFBlanco())
            {
                try
                {
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();


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
                            MessageBox.Show("DNI introducido incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void mtbdni_TextChanged(object sender, EventArgs e)
        {
            mtbDni.Text = mtbDni.Text.ToUpper();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            pbLogo.Visible = true;
            pnlEntrada.Visible = false;
            txtInfo.Clear();
        }

        private void btnPermanencia_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();

                    frmPermanencia = new FrmPermanencia();
                    frmPermanencia.Show();

                    if (frmPermanencia != null)
                    {
                        frmPermanencia.Activate();
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

        #region Validaciones
        private bool ValidarNIFBlanco()
        {
            bool ok = true;
            errorProvider.Clear();

            if (mtbDni.Text == "        -")
            {
                ok = false;
                errorProvider.SetError(mtbDni, "Ingrese DNI");
            }
            return ok;
        }

        #endregion
    }
}
