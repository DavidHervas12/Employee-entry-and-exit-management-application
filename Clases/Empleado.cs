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
            contrasenya = clave;
        }

        public Empleado()
        {
        }

        /// <summary>
        /// Agrega un empleado a la lista de empleados
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="emp"></param>
        /// <returns></returns>
        public int AgregarEmpleado(Empleado emp)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO empleados (nif,nombre,apellidos,admin,clave) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}')", emp.nif, emp.nombre, emp.apellidos, emp.administrador, emp.contrasenya);

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
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
                    Empleado empl = new Empleado(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                         reader.GetBoolean(3), reader.GetString(4));
                    listaEmpleados.Add(empl);
                }
            }
            // devolvemos la lista cargada con los usuarios.
            return listaEmpleados;
        }

        public static bool ComprobarEmpleado(Empleado emp)
        {
            string consulta = string.Format("SELECT * FROM empleados WHERE nif='{0}'", emp.nif);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
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
    }
}
