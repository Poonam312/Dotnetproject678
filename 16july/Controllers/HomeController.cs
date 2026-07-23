using 16july.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace 16july.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student{ Id=101, Name="abc" ,Age = 20,Course="Dot net Framework",Gender='F',Qualification="Undergraduate"},
                new Student{ Id=102, Name="abd" ,Age = 21,Course="java Framework",Gender='M',Qualification="Undergraduate"},
                new Student{ Id=103, Name="abe" ,Age = 22,Course="frontend Framework",Gender='F',Qualification="Undergraduate"},
                new Student{ Id=104, Name="abf" ,Age = 23,Course="backend Framework",Gender='F',Qualification="Undergraduate"},
            };
            return View(students);
        }

    }
}