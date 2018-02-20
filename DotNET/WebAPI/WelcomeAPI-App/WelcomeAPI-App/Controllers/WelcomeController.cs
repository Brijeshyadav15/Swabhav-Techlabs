using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WelcomeAPI_App.Controllers
{
    public class WelcomeController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Get Invoked");
        }

        public IHttpActionResult Post()
        {
            //throw new Exception();

            return Redirect("api/Welcome/Get");
        }
    }
}