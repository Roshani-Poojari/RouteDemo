using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes(); //attribute routing
            //route order matters-longer ones first,then general routs, last default route
            /*routes.MapRoute(
                name: "studentAddressById",
                url: "students/address/{id}",
                defaults: new { controller = "Student", action = "GetAddressOfStudentById", id = 1 }
                //constraints: new { id = @"\d+" }
                );

            routes.MapRoute(
                name: "studentById",
                url: "students/{id}",
                defaults: new { controller = "Student", action = "GetStudentById", id = 1 }
                //constraints: new { id = @"\d+" }
                );*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Student", action = "GetAllStudents", id = UrlParameter.Optional }
            );
        }
    }
}
