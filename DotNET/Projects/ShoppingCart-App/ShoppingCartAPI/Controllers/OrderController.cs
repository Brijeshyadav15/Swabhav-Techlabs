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
    [RoutePrefix("api/v1/ShoppingCart/User/{UserId}/Order")]
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

        [Route("DeleteOrder/{OrderID}")]
        [HttpGet]
        public IHttpActionResult DeleteOrder([FromUri] Guid OrderID)
        {
            var countBefore = _efr.CountAll();
            _efr.Delete(OrderID);
            var countAfter = _efr.CountAll();

            if (countBefore - 1 == countAfter)
                return Ok("Order Deleted");
            else
                return Ok("Order not Found!!");
        }

        [Route("UpdateOrder")]
        [HttpPost]
        public IHttpActionResult Update(Order order)
        {
            _efr.Update(order);
            return Ok("Order Updated");
        }
    }
}
