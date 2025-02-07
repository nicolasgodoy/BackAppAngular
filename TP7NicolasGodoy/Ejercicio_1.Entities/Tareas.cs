using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Entities
{
    public class Tareas
    {
        private int id;
        private string nombre;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string descripcion;

        public Tareas()
        {
        }

        public Tareas(int id, string nombre, DateTime fechaInicio, DateTime fechaFin, string descripcion )
        {
            this.id = id;
            this.nombre = nombre;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.descripcion = descripcion;
        }

        public int ID { get => id; set => id = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }

        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }

        public string Descripcion { get => descripcion; set => descripcion = value; }



    }
}
