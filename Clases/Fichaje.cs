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
        private DateTime dia;
        private DateTime hora_entrada;
        private DateTime hora_salida;
        private int situacion;

        public Fichaje(string nif)
        {
            nifEmpleado = nif;
            dia = DateTime.Now.Date;
            hora_entrada = DateTime.Now;
            hora_salida = DateTime.MinValue;
            situacion = 1;
        }

        public string NifEmpleado { get { return nifEmpleado; } set { nifEmpleado = value; } }
        public DateTime Dia { get { return dia; } set { dia = value; } }
        public DateTime Hora_entrada { get { return hora_entrada; } set { hora_entrada = value; } }
        public DateTime Hora_salida { get { return hora_salida; } }

        public int DarEntrada(Fichaje fichaje)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO fichajes (nif,fecha,hora_entrada,hora_salida,situacion) " +
                "VALUES (@nif,@fecha,@hora_entrada,@hora_salida,@situacion)");

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);

            comando.Parameters.AddWithValue("nif", fichaje.nifEmpleado);
            comando.Parameters.AddWithValue("fecha", fichaje.dia.ToString("yyyy/MM/dd"));
            comando.Parameters.AddWithValue("hora_entrada", fichaje.hora_entrada);
            comando.Parameters.AddWithValue("hora_salida", fichaje.hora_salida);
            comando.Parameters.AddWithValue("situacion", fichaje.situacion);
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

        //public static List<Fichaje> VerFichajesTotales()
        //{
        //    List<Fichaje> totalFichajes = new List<Fichaje>();
        //    String consulta = "SELECT * FROM fichajes";
        //    MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
        //    MySqlDataReader reader = comando.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        Fichaje nuevo = new Fichaje(reader.GetString(0));
        //        nuevo.fecha = reader.GetDateTime(1);
        //        nuevo.horaEntrada = Convert.ToDateTime(reader["horaentrada"]);
        //        nuevo.horaSalida = Convert.ToDateTime(reader["horasalida"]);
        //        nuevo.finalizado = reader.GetBoolean(4);

        //        totalFichajes.Add(nuevo);
        //    }

        //    return totalFichajes;
        //}

    }
}
