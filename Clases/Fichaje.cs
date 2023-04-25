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

        public Fichaje(string nif, int sit)
        {
            nifEmpleado = nif;
            dia = DateTime.Now;
            hora_entrada = DateTime.Now;
            if (situacion==2)
            {
                hora_salida = null;
            }
            else
            {
                hora
            }

        }

        public string NifEmpleado { get { return nifEmpleado; } set { nifEmpleado = value; } }
        public DateTime Dia { get { return dia; } set { dia = value; } }
        public DateTime Hora_entrada { get { return hora_entrada; } set { hora_entrada = value; } }
        public DateTime Hora_salida { get { return hora_salida; } }

        public int AgregarFichaje(Fichaje fichaje)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO empleados (nif,fecha,hora_entrada,hora_salida,situacion) " +
                "VALUES (@nif,@nom,@ape,@admin,@clave)");

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);

            comando.Parameters.AddWithValue("nif", fichaje.nifEmpleado);
            comando.Parameters.AddWithValue("fecha", fichaje.dia);
            comando.Parameters.AddWithValue("hora_entrada", fichaje.hora_entrada);
            comando.Parameters.AddWithValue("hora_salida", fichaje.hora_salida);
            comando.Parameters.AddWithValue("situacion", fichaje.stuacion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
    }
}
