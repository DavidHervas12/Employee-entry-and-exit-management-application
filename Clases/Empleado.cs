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
        private string contrasenya;

        public string Nif { get { return nif; } set { nif = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public bool Administrador { get { return administrador; } set { administrador = value; } }
        public string Contrasenya { get { return contrasenya; } set { contrasenya = value; } }

        public Empleado(string dni, string nom, string ape, bool admin, string clave)
        {
            nif = dni;
            nombre = nom;
            apellidos = ape;
            administrador = admin;
            if (admin)
            {
                contrasenya = clave;
            } else
            {
                contrasenya = "";
            }
        }

        public Empleado()
        {
        }

        //Método para agregar empleados
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
            comando.Parameters.AddWithValue("clave", emp.contrasenya);
            retorno = comando.ExecuteNonQuery(); 

            return retorno;
        }

        public static List<Empleado> BuscarEmpleado(string consulta)
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
                    emp.contrasenya = reader.GetString(4);

                    listaEmpleados.Add(emp);
                }
            }
            // devolvemos la lista cargada con los usuarios.
            return listaEmpleados;
        }

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
                    MessageBox.Show("Ese usuario no es administrador");
                    return esAdmin;
                }
            }
            else
            {
                MessageBox.Show("No hay ningún empleado con este dni");
                reader.Close();
                return esAdmin; //Estara falso por lo tanto no recibirá nada
            }
        }

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
