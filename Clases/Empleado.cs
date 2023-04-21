using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV7_David_Alberto.Clases
{
    class Empleado
    {
        private string nif;
        private string nombre;
        private string apellidos;
        private bool administrador;
        private string direccion;
        private string contrasenya;

        public string Nif { get { return nif; } set { nif = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public bool Administrador { get { return administrador; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Contrasenya { get { return contrasenya; } set { contrasenya = value; } }






    }
}
