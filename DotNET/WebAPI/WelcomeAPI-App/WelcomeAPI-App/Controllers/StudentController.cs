using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WelcomeAPI_App.Controllers
{
    [RoutePrefix("api/v1/SwabhavTech/Student")]
    public class StudentController : ApiController
    {
        private static readonly StudentService _studentservice = new StudentService();
        private static List<Student> students = new List<Student>();
        static StudentController()
        {
            students.Add(new Student(1, "brijesh", 22, "Ahmedabad"));
            students.Add(new Student(2, "Akash", 23, "Mumbai"));
            students.Add(new Student(3, "Ajay", 22, "Surat"));
            _studentservice.Save(students);
        }

        [Route("GetAllStudents")]
        public IHttpActionResult Get()
        {
            var allstudents = _studentservice.Students;// GetStudents();
            return Ok(allstudents);
        }

        [Route("GetAllStudents/{studentId}")]
        public IHttpActionResult GetAllStudents(int studentId)
        {
            if (studentId == 0)
                return NotFound();

            var stud = _studentservice.GetStudent(studentId);
            if (stud == null)
                return NotFound();

            return Ok(stud);
        }

        [Route("AddStudent")]
        public IHttpActionResult PostAddStudent(Student student)
        {
            return Ok(_studentservice.AddStudent(student));
        }

        [Route("UpdateStudent")]
        public IHttpActionResult PostUpdateStudent(Student student)
        {
            return Ok(_studentservice.UpdateStudent(student));
        }


    }
}