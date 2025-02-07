
using System.Collections.Generic;
using System.Web.Http;
using Ejercicio_1.Entities;
using Ejercicio_1.BLL;
using System.Web.Http.Cors;

namespace TP7NicolasGodoy.Controllers
{
    [EnableCors(origins:"*", headers: "*", methods:"GET,POST,PUT,DELETE,OPTIONS")]
    public class UsuarioController : ApiController
    {
        // GET: api/Usuario

        public IHttpActionResult Get()
        {
            UsuarioBussines usuarioBussines = new UsuarioBussines();
            List<Usuario> lista = usuarioBussines.ListaUsuarios();
            return Json(lista);


        }

        // GET: api/Usuario/5
        public Usuario Get(int id)
        {
            UsuarioBussines usuarioBussines = new UsuarioBussines();
            List<Usuario> lista = usuarioBussines.ListaUsuarios();
            Usuario unUsuario = lista.Find(x => x.ID == id);
            return unUsuario;


        }
        // AGREGAR UN USUARIO
        // POST: api/Usuario
        public void Post([FromBody] Usuario unUsuario)
        {
            UsuarioBussines usuarioBussines = new UsuarioBussines();
            usuarioBussines.AgregarUsuario(unUsuario);

        }

        // EDITAR UN USUARIO
        // PUT: api/Usuario/5
        public void Put([FromBody] Usuario unUsuario)
        {
            UsuarioBussines usuarioBussines = new UsuarioBussines();
           
            usuarioBussines.EditarUsuario(unUsuario);

        }

        // ELIMINAR UN USUARIO
        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
            UsuarioBussines usuarioBussines = new UsuarioBussines();
            usuarioBussines.EliminarUsuario(id);

        }
    }
}
