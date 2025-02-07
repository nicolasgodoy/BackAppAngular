using Ejercicio_1.DAL;
using Ejercicio_1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.BLL
{
    public class UsuarioBussines
    {
        public List<Usuario> ListaUsuarios()
        {
            UsuarioData usuarioData = new UsuarioData();
            return usuarioData.ListaUsuarios();
        }

        public bool AgregarUsuario(Usuario unUsuario)
        {
            UsuarioData usuarioData = new UsuarioData();
            return usuarioData.AgregarUsuario(unUsuario);
        }

        public bool EditarUsuario(Usuario unUsuario)
        {
            UsuarioData usuarioData = new UsuarioData();
            return usuarioData.EditarUsuario(unUsuario);
        }

        public bool EliminarUsuario(int idUsuario)
        {
            
            UsuarioData usuarioData = new UsuarioData();
            return usuarioData.EliminarUsuario(idUsuario);
        }




    }
}
