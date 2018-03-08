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
    public class OrderController : ApiController
    {
        private EntityFrameworkRepository<Order> _efr = new EntityFrameworkRepository<Order>();

        [Route("AddOrder")]
        [HttpPost]
        public IHttpActionResult PostAddProduct(Order order)
        {
            return Ok(_efr.Add(order));
        }

        [Route("GetOrders")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_efr.Get());
        }

        [Route("GetOrder/{OrderID}")]
        [HttpGet]
        public IHttpActionResult GetById([FromUri] Guid OrderID)
        {
            return Ok(_efr.GetById(OrderID));
        }

        [Route("DeleteProduct/{OrderID}")]
        [HttpGet]
        public IHttpActionResult DeleteProduct([FromUri] Guid OrderID)
        {
            var countBefore = _efr.CountAll();
            _efr.Delete(OrderID);
            var countAfter = _efr.CountAll();

            return countBefore == countAfter - 1 ? Ok("Product Deleted") : Ok("Product not Found!!");
        }

        [Route("UpdateOrder")]
        [HttpGet]
        public IHttpActionResult Update(Order order)
        {
            _efr.Update(order);
            return Ok("Product Updated");
        }
    }
}
