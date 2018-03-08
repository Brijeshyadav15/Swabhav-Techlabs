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
    [RoutePrefix("api/v1/ShoppingCart/LineItem")]
    public class LineItemController : ApiController
    {
        private EntityFrameworkRepository<LineItem> _efr = new EntityFrameworkRepository<LineItem>();

        [Route("AddLineItem")]
        [HttpPost]
        public IHttpActionResult PostAddProduct(LineItem lineitem)
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

            return countBefore == countAfter - 1 ? Ok("LineItem Deleted") : Ok("LineItem not Found!!");
        }

        [Route("UpdateLineItem")]
        [HttpGet]
        public IHttpActionResult Update(LineItem lineitem)
        {
            _efr.Update(lineitem);
            return Ok("LineItem Updated");
        }
    }
}
