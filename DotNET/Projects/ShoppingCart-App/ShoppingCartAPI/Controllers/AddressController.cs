using ShoppingCore.Entity_Framework.Repository;
using ShoppingCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoppingCartAPI.Controllers
{
    [RoutePrefix("api/v1/ShoppingCart/Address")]
    public class AddressController : ApiController
    {
        private EntityFrameworkRepository<Address> _efr = new EntityFrameworkRepository<Address>();

        [Route("AddAddress")]
        [HttpPost]
        public IHttpActionResult PostAddProduct(Address address)
        {
            return Ok(_efr.Add(address));
        }

        [Route("GetAddresses")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_efr.Get());
        }

        [Route("GetAddress/{AddressID}")]
        [HttpGet]
        public IHttpActionResult GetById([FromUri] Guid AddressID)
        {
            return Ok(_efr.GetById(AddressID));
        }

        [Route("DeleteAddress/{AddressID}")]
        [HttpGet]
        public IHttpActionResult DeleteLineItemID([FromUri] Guid AddressID)
        {
            var countBefore = _efr.CountAll();
            _efr.Delete(AddressID);
            var countAfter = _efr.CountAll();

            return countBefore == countAfter - 1 ? Ok("Address Deleted") : Ok("Address not Found!!");
        }

        [Route("UpdateAddress")]
        [HttpGet]
        public IHttpActionResult Update(Address address)
        {
            _efr.Update(address);
            return Ok("Address Updated");
        }
    }
}
