using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DIApiApp;
using System.Web.Http;
using System.Net;

namespace DIApiApp.Controllers
{
    public class StudentController : ApiController
    {
        private IRepository<Student> _repo;

        public StudentController(IRepository<Student> _repo)
        {
            this._repo = _repo;
        }

        [System.Web.Http.Route("api/v1/GetStudents")]
        public IHttpActionResult Get()
        {
            var students = _repo.Get().ToList();
            return Ok(students);
        }
    }
}