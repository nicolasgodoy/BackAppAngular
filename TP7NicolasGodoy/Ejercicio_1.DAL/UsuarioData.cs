using Ejercicio_1.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ejercicio_1.DAL
{
    public class UsuarioData // public para poder verlo una vez referenciado
    {

        public List<Usuario> ListaUsuarios()
        {

            try
            {
                
                Conexion con = new Conexion();
                string Sentencia = "SELECT * FROM Usuarios;";
                SqlCommand comando = new SqlCommand(Sentencia, con.conectar());
                SqlDataReader dataReader = comando.ExecuteReader();


                List<Usuario> listaUsuarios = new List<Usuario>();
                while (dataReader.Read())
                {
                    Usuario unUsuario = new Usuario();
                    unUsuario.ID = int.Parse(dataReader["Id"].ToString());
                    unUsuario.Nombre = dataReader["Nombre"].ToString();
                    unUsuario.Apellido = dataReader["Apellido"].ToString();
                    unUsuario.Edad = int.Parse(dataReader["Edad"].ToString());



                    listaUsuarios.Add(unUsuario);
                }

                con.desconectar();
                ;
                return listaUsuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la bd" + ex.Message);
            }



        }


        public bool AgregarUsuario(Usuario unUsuario)
        {
            try
            {
                Conexion con = new Conexion();
                string Sentencia = $@"INSERT INTO Usuarios ([Nombre],[Apellido],[Edad])VALUES ('{unUsuario.Nombre}','{unUsuario.Apellido}','{unUsuario.Edad}')"; // INTERPOLACION

                SqlCommand comando = new SqlCommand(Sentencia, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }


            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la bd" + ex.Message);
            }



        }

        public bool EditarUsuario(Usuario unUsuario)
        {

            try
            {
                Conexion con = new Conexion();
                string Sentencia = $"UPDATE Usuarios SET Nombre='{unUsuario.Nombre}',Apellido ='{unUsuario.Apellido}',Edad='{unUsuario.Edad}' Where Id = {unUsuario.ID} ";

                SqlCommand comando = new SqlCommand(Sentencia, con.conectar());


                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {

                    con.desconectar();
                    return true;

                }
                else
                {
                    con.desconectar();
                    return false;
                }




            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la bd" + ex.Message);
            }
        }


        public bool EliminarUsuario(int idUsuario)
        {

            try
            {
                Conexion con = new Conexion();
                string Sentencia = $"DELETE FROM Usuarios Where Id = {idUsuario}";

                SqlCommand comando = new SqlCommand(Sentencia, con.conectar());

                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la bd" + ex.Message);
            }
        }
    }
}