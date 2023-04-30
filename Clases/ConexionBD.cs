using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AEV7_David_Alberto.Clases
{
    internal class ConexionBD
    {
        private static MySqlConnection instancia = null;

        private static readonly object padlock = new object();

        private ConexionBD () { }

        /// <summary>
        /// Propidad para el acceso de lectura (GET) a la conexión.
        /// </summary>
        public static MySqlConnection Conexion
        {
            get
            {
                lock(padlock)
                {
                    if(instancia == null)
                    {
                        instancia = new MySqlConnection();
                        instancia.ConnectionString = "server=127.0.0.1;database=BDFichajes;uid=root;pwd=";
                    }
                    return instancia;
                }
            }
        }

        /// <summary>
        /// Metodo público para abrir la conexión
        /// </summary>
        public static void AbrirConexion()
        {
            if (instancia!=null)
            {
                instancia.Open();
            }
        }

        /// <summary>
        /// Metodo público para cerrar la conexión
        /// </summary>
        public static void CerrarConexion()
        {
            if (instancia!=null)
            {
                instancia.Close();
            }
        }
    }
}
