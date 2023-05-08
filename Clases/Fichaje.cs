using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEV7_David_Alberto.Clases
{
    class Fichaje
    {
        private string nifEmpleado;
        private DateTime fecha;
        private DateTime hora_entrada;
        private DateTime hora_salida;
        private bool finalizado;

        public string NifEmpleado { get { return nifEmpleado; } set { nifEmpleado = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public DateTime Hora_entrada { get { return hora_entrada; } set { hora_entrada = value; } }
        public DateTime Hora_salida { get { return hora_salida; } set { hora_salida = value; } }
        public bool Finalizado { get { return finalizado; } set { finalizado = value; } }

        public Fichaje(string nif)
        {
            nifEmpleado = nif;
            fecha = DateTime.Now.Date;
            hora_entrada = DateTime.Now;
            hora_salida = DateTime.MinValue; //Valor mínimo posible
            finalizado = false;
        }

        public Fichaje()
        {
        }

        /// <summary>
        /// Metodo para agregar un fichaje de entrada
        /// </summary>
        /// <param name="fichaje">Instancia del fichaje que se quiere añadir en la base de datos</param>
        /// <returns>Devuelve numero de filas afectadas</returns>
        public int DarEntrada(Fichaje fichaje)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO fichajes (nif,fecha,hora_entrada,hora_salida,finalizado) " +
                "VALUES (@nif,@fecha,@hora_entrada,@hora_salida,@finalizado)");

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);

            comando.Parameters.AddWithValue("nif", fichaje.nifEmpleado);
            comando.Parameters.AddWithValue("fecha", fichaje.fecha);
            comando.Parameters.AddWithValue("hora_entrada", fichaje.hora_entrada);
            comando.Parameters.AddWithValue("hora_salida", fichaje.hora_salida);
            comando.Parameters.AddWithValue("finalizado", fichaje.finalizado);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }


        /// <summary>
        /// Metodo para agregar un fichaje de salida
        /// </summary>
        /// <param name="fich">Instancia del fichaje que se quiere añadir en la base de datos</param>
        /// <returns>Devuelve numero de filas afectadas</returns>
        public int DarSalida(Fichaje fich)
        {
            int retorno;
            string consulta = String.Format("UPDATE fichajes SET hora_salida=@hora_salida,finalizado=@fin WHERE nif=@nif AND finalizado=0"); //Se actualizará los que el finalizado sea a false ya que todavía no han terminado

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.AddWithValue("hora_salida", fich.hora_salida);
            comando.Parameters.AddWithValue("fin", fich.finalizado);
            comando.Parameters.AddWithValue("nif", fich.nifEmpleado);

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        /// <summary>
        /// Método para adquirir la lista de todos los fichajes que hay en la base de datos.
        /// </summary>
        /// <param name="consulta">Consulta SQL para obtener los fichajes</param>
        /// <returns>La lista de todos los fichajes que hay en la tabla fichajes.</returns>
        public static List<Fichaje> VerFichajesTotales(string consulta)
        {
            List<Fichaje> totalFichajes = new List<Fichaje>();
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Fichaje f = new Fichaje(reader.GetString(0));
                f.fecha = reader.GetDateTime(1);
                f.hora_entrada = Convert.ToDateTime(reader["hora_entrada"]);
                f.hora_salida = Convert.ToDateTime(reader["hora_salida"]);
                f.finalizado = reader.GetBoolean(4);

                totalFichajes.Add(f);
            }
            reader.Close();
            return totalFichajes;
        }

        /// <summary>
        /// Método para adquirir la lista de todos los fichajes mediante dos fechas con la duración total de la permanencia.
        /// </summary>
        /// <param name="nif">NIF del empleado que se desea calcular</param>
        /// <param name="fInicial">Fecha inicial</param>
        /// <param name="fFinal">Fecha final</param>
        /// <returns>Lista de usuarios calculados mediante dos fechas con la duración total</returns>
        public static List<Fichaje> ListaFechasFichajes(string nif, DateTime fInicial, DateTime fFinal)
        {
            List<Fichaje> lista = new List<Fichaje>();
            string consulta = String.Format("SELECT * FROM fichajes WHERE nif=@nif AND fecha>=@fInicial AND fecha<=@fFinal");

            // Creo el objeto command al cual le paso la consulta y la conexión
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.AddWithValue("nif", nif);
            comando.Parameters.AddWithValue("fInicial", fInicial);
            comando.Parameters.AddWithValue("fFinal", fFinal);

            // Ejecuto el comando y recibo en un DataReader la lista de registros seleccionados.
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader y cargamos la lista de fichajes desde una fecha a otra
                while (reader.Read())
                {
                    Fichaje fich = new Fichaje();
                    fich.fecha = reader.GetDateTime(1);
                    fich.hora_entrada = Convert.ToDateTime(reader["hora_entrada"]);
                    fich.hora_salida = Convert.ToDateTime(reader["hora_salida"]);
                    fich.finalizado = reader.GetBoolean(4);
                    lista.Add(fich);
                }
            }
            return lista;
        }

        #region Validaciones 

        /// <summary>
        /// Metodo para comprobar si se ha hecho la entrada del fichaje correctamente
        /// </summary>
        /// <param name="dni">DNI/NIF del fichaje que se desea buscar</param>
        /// <returns>Devuelve true si hay filas que han hecho entrada o false si no hay</returns>
        public static bool ComprobarEntradaFichaje(MaskedTextBox dni)
        {
            string nif = dni.Text.Substring(0, 8) + dni.Text[9];
            string consulta = string.Format("SELECT * FROM fichajes WHERE nif=@nif AND finalizado=0");
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.Parameters.AddWithValue("nif", nif);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            { // Devuelve true si el fichaje se ha dado de entrada.
                reader.Close();
                return true;
            }
            else
            { // Devuelve false si no se ha dado de entrada
                reader.Close();
                return false;
            }
        }
        #endregion

    }
}
