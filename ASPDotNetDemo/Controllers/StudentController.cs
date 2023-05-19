using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASPDotNetDemo.Models;

namespace ASPDotNetDemo.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult AddStudent()
        {
            List<string> students = new List<string>() { "Select City","Pune","Mumbai","Nashik","Nagpur"};
            ViewData["City"]=new SelectList(students);  
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(IFormCollection form)
        {
            ViewBag.RollNo = form["rollno"];
            ViewBag.Name = form["name"];
            ViewBag.City = form["city"];
            ViewBag.Gender = form["gender"];
            ViewBag.CurrentYear = form["year"];
            return View("StudentDetails");
        }
        public IActionResult StudentList()
        {
            List<Student> Students = new List<Student>()
            {
                new Student{RollNo=1,Name="Ashwini",City="Pune",Percentage=67.77M},
                new Student{RollNo=2,Name="Pratik",City="Mumbai",Percentage=87.77M},
                new Student{RollNo=3,Name="Amol",City="Goa",Percentage=87.77M},
                new Student{RollNo=4,Name="Priyanka",City="Nashik",Percentage=69.77M},
                new Student{RollNo=5,Name="Akshay",City="Pune",Percentage=68.77M},
            };
            ViewBag.Students = Students;

            return View();  
        }
    }
}
