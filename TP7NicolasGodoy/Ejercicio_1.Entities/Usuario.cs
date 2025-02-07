using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio_1.Entities
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private int edad;

        public Usuario()
        {
        }

        public Usuario(int id,string nombre, string apellido, int edad){

            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public int ID { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public int Edad { get => edad; set => edad = value; }



    }
}