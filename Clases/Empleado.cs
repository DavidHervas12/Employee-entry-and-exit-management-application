using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace AEV7_David_Alberto.Clases
{
    class Empleado
    {
        private string nif;
        private string nombre;
        private string apellidos;
        private bool administrador = false;
        private string clave;

        public string Nif { get { return nif; } set { nif = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public bool Administrador { get { return administrador; } set { administrador = value; } }
        public string Clave { get { return clave; } set { clave = value; } }

        public Empleado(string dni, string nom, string ape, bool admin, string cl)
        {
            nif = dni;
            nombre = nom;
            apellidos = ape;
            administrador = admin;
            if (admin) clave = cl;
            else clave = "";
        }

        public Empleado()
        {
        }

        /// <summary>
        /// Método para agregar empleados.
        /// </summary>
        /// <param name="emp">Instancia del empleado que se quiere añadir a la base de datos.</param>
        /// <returns>Devuelve el número de filas afectado.</returns>
        public int AgregarEmpleado(Empleado emp)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO empleados (nif,nombre,apellidos,admin,clave) " +
                "VALUES (@nif,@nom,@ape,@admin,@clave)");

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);

            comando.Parameters.AddWithValue("nif", emp.nif);
            comando.Parameters.AddWithValue("nom", emp.nombre);
            comando.Parameters.AddWithValue("ape", emp.apellidos);
            comando.Parameters.AddWithValue("admin", emp.administrador);
            comando.Parameters.AddWithValue("clave", emp.clave);
            retorno = comando.ExecuteNonQuery(); 

            return retorno;
        }

        /// <summary>
        /// Método para obtener la lista de todos los empleados que hay en la base de datos.
        /// </summary>
        /// <param name="consulta">La consulta sql para obtener los empleados</param>
        /// <returns>La lista de todos los empleados que hay en la tabla empleados.</returns>
        public static List<Empleado> VerEmpleadosTotales(string consulta)
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader (registro por registro) y cargamos la lista de usuarios.
                while (reader.Read())
                {
                    Empleado emp = new Empleado();
                    emp.nif = reader.GetString(0);
                    emp.nombre = reader.GetString(1);
                    emp.apellidos = reader.GetString(2);
                    emp.administrador = reader.GetBoolean(3);
                    emp.clave = reader.GetString(4);

                    listaEmpleados.Add(emp);
                }
            }
            // devolvemos la lista cargada con los usuarios.
            return listaEmpleados;
        }

        /// <summary>
        /// Método para obtener un empleado concreto de de la base de datos.
        /// </summary>
        /// <param name="dni">Dni del empleado que se desea buscar.</param>
        /// <returns>El empleado con el que coincide el dni.</returns>
        public static Empleado BuscarEmpleado(string dni)
        {
            string consulta = string.Format("SELECT * FROM empleados WHERE nif=@nif");
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.AddWithValue("nif", dni);
            MySqlDataReader reader = comando.ExecuteReader();
            

            if (reader.HasRows && reader.Read())   // En caso que se hayan registros en el objeto reader
            {
                Empleado emp = new Empleado();
                emp.nif = reader.GetString(0);
                emp.nombre = reader.GetString(1);
                emp.apellidos = reader.GetString(2);
                emp.administrador = reader.GetBoolean(3);
                emp.clave = reader.GetString(4);
                reader.Close();
                return emp;
            }
            else
            {
                reader.Close();
                return null;
            }
        }

        /// <summary>
        /// Método para eliminar un empleado.
        /// </summary>
        /// <param name="nif">El dni del empleado que se desea eliminar.</param>
        /// <returns>Devuelve el numero de filas afectadas.</returns>
        public static int EliminaEmpleado(TextBox nif)
        {
            int retorno;
            string consulta = string.Format("DELETE FROM empleados WHERE nif=@nif");
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.AddWithValue("nif", nif.Text);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        #region Validaciones

        /// <summary>
        /// Método para comprobar si el empleado con el dni especificado ya está en la base de datos.
        /// </summary>
        /// <param name="dni">DNI</param>
        /// <returns>Devuelve false si el empleado está en la base de datos y true en el caso contrario</returns>
        public static bool ComprobarEmpleado(string dni)
        {
            string consulta = string.Format("SELECT * FROM empleados WHERE nif=@nif");
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.AddWithValue("nif", dni);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            { // Devuelve false si el empleado está en la base de datos.
                reader.Close();
                return false;
            }
            else
            { // Devuelve true si el empleado no está en la base de datos.
                reader.Close();
                return true;
            }
        }

        /// <summary>
        /// Método para comprobar si un empleado es administrador.
        /// </summary>
        /// <param name="dni">DNI del empleado.</param>
        /// <returns>Devuelve true si el empleado es administrador y false en caso contrario.</returns>
        public static bool ComprobarAdministrador(MaskedTextBox dni)
        {
            string nif = dni.Text.Substring(0, 8) + dni.Text[9]; //NIF sin guiones
            FrmPrincipal.NIF = nif;

            string consulta = string.Format("SELECT * FROM empleados WHERE nif=@nif");
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.AddWithValue("nif", nif);
            MySqlDataReader reader = comando.ExecuteReader();
            bool esAdmin = false;

            if (reader.Read() && reader.HasRows)
            {
                esAdmin = reader.GetBoolean(3);
                reader.Close();
                if (esAdmin)
                {
                    return esAdmin;
                }
                else
                {
                    MessageBox.Show("Este usuario no es administrador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return esAdmin;
                }
            }
            else
            {
                MessageBox.Show("No hay ningún empleado con este dni", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reader.Close();
                return esAdmin; //Estara falso por lo tanto no recibirá nada
            }
        }

        /// <summary>
        /// Método para comprobar si la clave introducida es correcta.
        /// </summary>
        /// <param name="clave">Clave de administrador.</param>
        /// <returns>Devuelve true si la clave es correcta y false en caso contrario</returns>
        public static bool ComprobarClave(TextBox clave)
        {
            string consulta = String.Format("SELECT * FROM empleados WHERE nif=@nif AND clave=@clave");
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.AddWithValue("nif", FrmPrincipal.NIF);
            comando.Parameters.AddWithValue("clave", clave.Text);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }

        /// <summary>
        /// Método para validar el nif.
        /// </summary>
        /// <param name="dni">NIF</param>
        /// <returns>Devuelve true si el nif es válido y false en caso contrario.</returns>
        public static bool ValidaNif(TextBox dni)
        {
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            int resto;
            string letraCorrecta;

            int num = int.Parse(dni.Text.Substring(0, 8));
            string letraDato = dni.Text[8].ToString();

            resto = num % 23;
            letraCorrecta = letras[resto].ToString();

            if (letraDato == letraCorrecta) return true;
            return false;
        }

        /// <summary>
        /// Método para validar el nif.
        /// </summary>
        /// <param name="dni">NIF</param>
        /// <returns>Devuelve true si el nif es válido y false en caso contrario.</returns>
        public static bool ValidaNif(MaskedTextBox dni)
        {
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            int resto;
            string letraCorrecta;

            int num = int.Parse(dni.Text.Substring(0, 8));
            string letraDato = dni.Text[9].ToString();

            resto = num % 23;
            letraCorrecta = letras[resto].ToString();

            if (letraDato == letraCorrecta) return true;
            return false;
        }
        #endregion
    }
}
