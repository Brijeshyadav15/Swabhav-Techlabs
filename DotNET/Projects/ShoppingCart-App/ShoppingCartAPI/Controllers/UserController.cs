using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoppingCore;
using ShoppingCore.Entity_Framework.Repository;
using ShoppingCore.Models;

namespace ShoppingCartAPI.Controllers
{
    [RoutePrefix("api/v1/ShoppingCart/User")]
    public class UserController : ApiController
    {
        private EntityFrameworkRepository<User> _efr = new EntityFrameworkRepository<User>();

        [Route("AddUser")]
        [HttpPost]
        public IHttpActionResult PostAddUser(User user)
        {
            return Ok(_efr.Add(user));
        }

        [Route("GetUsers")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_efr.Get());
        }

        [Route("GetUser/{UserId}")]
        [HttpGet]
        public IHttpActionResult GetById([FromUri] Guid UserId)
        {
            return Ok(_efr.GetById(UserId));
        }

        [Route("DeleteUser/{UserId}")]
        [HttpGet]
        public IHttpActionResult DeleteUser([FromUri] Guid UserId)
        {
            var countBefore = _efr.CountAll();
            _efr.Delete(UserId);
            var countAfter = _efr.CountAll();

            if (countBefore == countAfter - 1)
                return Ok("User Deleted");
            else
                return Ok("User not Found!!");
        }

        [Route("UpdateUser")]
        [HttpPost]
        public IHttpActionResult Update(User user)
        {
            _efr.Update(user);
            return Ok("User Updated");
        }
    }
}
