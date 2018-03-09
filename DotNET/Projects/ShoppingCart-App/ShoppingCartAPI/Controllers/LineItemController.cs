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
    [RoutePrefix("api/v1/ShoppingCart/User/{UserId}/Order/{OrderId}/LineItem")]
    public class LineItemController : ApiController
    {
        private EntityFrameworkRepository<LineItem> _efr = new EntityFrameworkRepository<LineItem>();

        [Route("AddLineItem")]
        [HttpPost]
        public IHttpActionResult PostAddLineItem(LineItem lineitem)
        {
            return Ok(_efr.Add(lineitem));
        }

        [Route("GetLineItems")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_efr.Get());
        }

        [Route("GetLineItem/{LineItemID}")]
        [HttpGet]
        public IHttpActionResult GetById([FromUri] Guid LineItemID)
        {
            return Ok(_efr.GetById(LineItemID));
        }

        [Route("DeleteLineItem/{LineItemID}")]
        [HttpGet]
        public IHttpActionResult DeleteLineItemID([FromUri] Guid LineItemID)
        {
            var countBefore = _efr.CountAll();
            _efr.Delete(LineItemID);
            var countAfter = _efr.CountAll();

            if (countBefore - 1 == countAfter)
                return Ok("LineItem Deleted");
            else
                return Ok("LineItem not Found!!");
        }

        [Route("UpdateLineItem")]
        [HttpPost]
        public IHttpActionResult Update(LineItem lineitem)
        {
            _efr.Update(lineitem);
            return Ok("LineItem Updated");
        }
    }
}
