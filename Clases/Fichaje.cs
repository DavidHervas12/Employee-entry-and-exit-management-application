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
        private bool fichaje_entrada = false;
        private bool fichaje_salida = true;

        public string NifEmpleado { get { return nifEmpleado; } set { nifEmpleado = value; } }
        public DateTime Dia { get { return dia; } set { dia = value; } }
        public DateTime Hora_entrada { get { return hora_entrada; } set { hora_entrada = value; } }
        public DateTime Hora_salida { get { return hora_salida; } }
        public bool Fichaje_entrada { get { return fichaje_entrada; } set { fichaje_entrada = value; } }
        public bool Fichaje_salida { get { return fichaje_salida; } set { fichaje_salida = value; } }


    }
}
