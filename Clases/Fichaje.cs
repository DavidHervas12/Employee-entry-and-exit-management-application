using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV7_David_Alberto.Clases
{
    class Fichaje
    {
        private string nifEmpleado;
        private DateTime fecha;
        private DateTime hora_entrada;
        private DateTime hora_salida;
        private bool finalizado;

        public Fichaje(string nif)
        {
            nifEmpleado = nif;
            fecha = DateTime.Now.Date;
            hora_entrada = DateTime.Now;
            hora_salida = DateTime.MinValue;
            finalizado = false;
        }

        public string NifEmpleado { get { return nifEmpleado; } set { nifEmpleado = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public DateTime Hora_entrada { get { return hora_entrada; } set { hora_entrada = value; } }
        public DateTime Hora_salida { get { return hora_salida; } }

        public int DarEntrada(Fichaje fichaje)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO fichajes (nif,fecha,hora_entrada,hora_salida,finalizado) " +
                "VALUES (@nif,@fecha,@hora_entrada,@hora_salida,@finalizado)");

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);

            comando.Parameters.AddWithValue("nif", fichaje.nifEmpleado);
            comando.Parameters.AddWithValue("fecha", fichaje.fecha.ToString("yyyy/MM/dd"));
            comando.Parameters.AddWithValue("hora_entrada", fichaje.hora_entrada);
            comando.Parameters.AddWithValue("hora_salida", fichaje.hora_salida);
            comando.Parameters.AddWithValue("finalizado", fichaje.finalizado);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }


        //public int DarSalida()
        //{

        //    int retorno;
        //    String consulta = "UPDATE fichajes SET horasalida=@hs,finalizado=@fin WHERE nombre=@nom AND finalizado=0";

        //    MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
        //    comando.Parameters.AddWithValue("nom", this.nombre);
        //    comando.Parameters.AddWithValue("hs", this.horaSalida);
        //    comando.Parameters.AddWithValue("fin", this.finalizado);

        //    retorno = comando.ExecuteNonQuery();
        //    return retorno;
        //}

        public static List<Fichaje> BuscarFichajes(string consulta)
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

            return totalFichajes;
        }

    }
}
