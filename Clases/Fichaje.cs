﻿using MySql.Data.MySqlClient;
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
