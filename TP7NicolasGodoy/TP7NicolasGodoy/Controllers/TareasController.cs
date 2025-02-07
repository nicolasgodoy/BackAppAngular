using Ejercicio_1.BLL;
using Ejercicio_1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace TP7NicolasGodoy.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "GET,POST,PUT,DELETE,OPTIONS")]
    public class TareasController : ApiController
    {

        public IHttpActionResult Get()
        {
            TareasBussines tareaBussines = new TareasBussines();
            List<Tareas> lista = tareaBussines.ListaTareas();
            return Json(lista);


        }

        // GET: api/Usuario/5
        public Tareas Get(int id)
        {
            TareasBussines tareaBussines = new TareasBussines();
            List<Tareas> lista = tareaBussines.ListaTareas();
            Tareas unaTarea = lista.Find(x => x.ID == id);
            return unaTarea;


        }
        // AGREGAR UN USUARIO
        // POST: api/Usuario
        public void Post([FromBody] Tareas unaTarea)
        {
            TareasBussines tareaBussines = new TareasBussines();
            tareaBussines.AgregarTareas(unaTarea);

        }

        // EDITAR UN USUARIO
        // PUT: api/Usuario/5
        public void Put([FromBody] Tareas unaTarea)
        {
            TareasBussines tareaBussines = new TareasBussines();
            tareaBussines.EditarTareas(unaTarea);

        }

        // ELIMINAR UN USUARIO
        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
            TareasBussines tareaBussines = new TareasBussines();
            tareaBussines.EliminarTareas(id);

        }
    }
}
