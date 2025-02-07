using Ejercicio_1.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace Ejercicio_1.DAL
{
    public class TareasData
    {
        public List<Tareas> ListaTareas()
        {

            try
            {
                Conexion con = new Conexion();
                string Sentencia = "SELECT * FROM Tareas;";
                SqlCommand comando = new SqlCommand(Sentencia, con.conectar());
                SqlDataReader dataReader = comando.ExecuteReader();


                List<Tareas> listaTareas = new List<Tareas>();
                while (dataReader.Read())
                {
                    Tareas unaTarea = new Tareas();
                    unaTarea.ID = int.Parse(dataReader["Id"].ToString());
                    unaTarea.Nombre = dataReader["Nombre"].ToString();
                    unaTarea.FechaInicio = DateTime.Parse(dataReader["fechaInicio"].ToString());
                    unaTarea.FechaFin = DateTime.Parse(dataReader["fechaFin"].ToString());
                    unaTarea.Descripcion = (dataReader["descripcion"].ToString());



                    listaTareas.Add(unaTarea);
                }

                con.desconectar();
                ;
                return listaTareas;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la bd" + ex.Message);
            }



        }

        
        public bool AgregarTareas(Tareas unaTarea)
        {
            try
            {
                Conexion con = new Conexion();
                string Sentencia = $@"INSERT INTO Tareas ([Nombre],[FechaInicio],[FechaFin],[Descripcion])VALUES ('{unaTarea.Nombre}','{unaTarea.FechaInicio}','{unaTarea.FechaFin}','{unaTarea.Descripcion}')"; // INTERPOLACION

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

        public bool EditarTareas(Tareas unaTarea)
        {

            try
            {
                Conexion con = new Conexion();
                string Sentencia = $"UPDATE Tareas SET Nombre='{unaTarea.Nombre}',FechaInicio='{unaTarea.FechaInicio.ToString("yyyy-MM-dd")}',FechaFin='{unaTarea.FechaFin.ToString("yyyy-MM-dd")}',Descripcion='{unaTarea.Descripcion}' Where Id = {unaTarea.ID} ";

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


        public bool EliminarTareas(int idTareas)
        {

            try
            {
                Conexion con = new Conexion();
                string Sentencia = $"DELETE FROM Tareas Where Id = {idTareas}";

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
