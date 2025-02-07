using Ejercicio_1.DAL;
using Ejercicio_1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.BLL
{
    public class TareasBussines
    {

        public List<Tareas> ListaTareas()
        {
            TareasData tareasData = new TareasData();
            return tareasData.ListaTareas();
        }

        public bool AgregarTareas(Tareas unaTarea)
        {
            TareasData tareasData = new TareasData();
            return tareasData.AgregarTareas(unaTarea);
        }

        public bool EditarTareas(Tareas unaTarea)
        {
            TareasData tareasData = new TareasData();
            return tareasData.EditarTareas(unaTarea);
        }

        public bool EliminarTareas(int idTarea)
        {

            TareasData tareasData = new TareasData();
            return tareasData.EliminarTareas(idTarea);
        }
    }
}
