using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoppingCore;
using ShoppingCore.Entity_Framework.Repository;
using ShoppingCore.Models;
using ShoppingCore.Service;
using System.Web.Http.Cors;

namespace ShoppingCartAPI.Controllers
{
    [RoutePrefix("api/v1/ShoppingCart/User")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        private EntityFrameworkRepository<User> _efr = new EntityFrameworkRepository<User>();

        [Route("AddUser")]
        [HttpPost]
        public IHttpActionResult PostAddUser(User user)
        {
            EmailService emailservice = new ShoppingCore.Service.EmailService();
            user.Password = new PasswordService().GeneratePassword(10);
            emailservice.SendRegisterMail("Shopping Cart User Registration",user.Email,user.Name,user.Password, "http://localhost:4200/Login");
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

        [Route("GetUserCount")]
        [HttpGet]
        public IHttpActionResult GetUserCount()
        {
            return Ok(_efr.CountAll());
        }

        [Route("CheckLogin")]
        [HttpPost]
        public IHttpActionResult CheckLogin(User user)
        {
            AuthenicationService auth = new AuthenicationService();
            var result = auth.CheckLogin(user.Email,user.Password);
            return Ok(result);
        }

        [Route("GetUser")]
        [HttpGet]
        public IHttpActionResult GetLoginedUser(string email)
        {
            AuthenicationService auth = new AuthenicationService();
            var result = auth.GetUser(email);
            return Ok(result);
        }
    }
}
