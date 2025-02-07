using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ejercicio_1.DAL
{
    public class Conexion
    {
            // ACA ES DONDE ABRIMOS LA CONEXION A LA BASE DE DATOS
            SqlConnection con;
            public Conexion()
            {
            con = new SqlConnection("Server=(localdb)\\mssqllocaldb;initial catalog=BasePruebaAngular;integrated security=true"); // PARA TRABAJAR LOCAL
            //con = new SqlConnection("Data Source=CrudAngularDB.mssql.somee.com;Initial Catalog=CrudAngularDB;user id=usser123_SQLLogin_1;pwd=j8vgakdrn6;TrustServerCertificate=True;"); SERVIDOR SE VOLVIO PAGO
            //con = new SqlConnection("Data Source=SQL1002.site4now.net;Initial Catalog=db_ab28c4_basepruebaangular;User Id=db_ab28c4_basepruebaangular_admin;Password=Milanesa35772799;");
            }

        // METODO CONECTAR
        public SqlConnection conectar()
            {
                try
                {
                    con.Open();
                    return con;
                }
                catch (Exception)
                {
                    return null;
                }

            }
            // METODO DESCONECTAR
            public bool desconectar()
            {
                try
                {
                    con.Close();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
    }
}
