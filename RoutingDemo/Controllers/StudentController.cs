using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoutingDemo.Models;

namespace RoutingDemo.Controllers
{
    [RoutePrefix("students")]
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>()
        {
            new Student() { Id = 1,
                            Name="Allen",
                            Age=34,
                            Address=new Address(){
                                    Id=101,
                                    Country="India",
                                    State="Goa",
                                    City="Panjim"
                            }
            },new Student(){
                            Id=2,
                            Name="Mary",
                            Age=42,
                            Address=new Address(){
                                    Id=101,
                                    Country="India",
                                    State="Punjab",
                                    City="Mohali"
                            }
            }
        };

        // GET: Student
        [Route("")]
        public ActionResult GetAllStudents()
        {
            var data = students;
            return View(students);
        }
        [Route("{id:int}")]
        public ActionResult GetStudentById(int id)
        {
            var student = students.FirstOrDefault(x => x.Id == id);
            return View(student);
        }
        [Route("address/{id}")]
        public ActionResult GetAddressOfStudentById(int id)
        {
            var studentAddress = students.Where(x => x.Id == id).Select(s => s.Address).FirstOrDefault();
            return View(studentAddress);
        }
        [Route("~/about-us")] //ek action method ke do routes ho sakte he 
        [Route("~/aboutUs")] // ~ symbol will by pass prefix
        public string AboutUs()
        {
            return "This is about us";
        }
        [Route("{id}")]
        public string Display(string id)
        {
            return "Your id: " + id;
        }
    }
}