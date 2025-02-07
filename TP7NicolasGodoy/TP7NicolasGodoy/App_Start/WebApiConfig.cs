
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace TP7NicolasGodoy
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Web API configuration and services
            // ACTIVAR PUERTO PARA QUE CHROME ME DEJE ACCEDER AL LOCALHOST:3000 
            /*PARA TRABAJAR LOCAL var cors = new EnableCorsAttribute("http://localhost:4200", "*", "*");*/
            //var cors = new EnableCorsAttribute("https://crud-angular-one.vercel.app", "*", "*");
            //config.EnableCors(cors);

            //var cors2 = new EnableCorsAttribute("https://crud-react-xi.vercel.app", "*", "*");
            //config.EnableCors(cors2);

            var cors = new EnableCorsAttribute("*", "*", "*"); //FORMA QUE DETECTE CUALQUIER ORIGINS NO ES BUENA PRACTICA PERO PARA PODER TENER 2 PROYECTOS CON LA MISMA API EN PRODUCCION
            config.EnableCors(cors);





            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
