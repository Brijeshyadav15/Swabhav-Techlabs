using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoppingCore.Entity_Framework.Repository;
using ShoppingCore.Models;

namespace ShoppingCartAPI.Controllers
{
    public class ProductController : ApiController
    {
        private EntityFrameworkRepository<Product> _efr = new EntityFrameworkRepository<Product>();

        [Route("AddProduct")]
        [HttpPost]
        public IHttpActionResult PostAddProduct(Product product)
        {
            return Ok(_efr.Add(product));
        }

        [Route("GetProducts")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_efr.Get());
        }

        [Route("GetProduct/{ProductID}")]
        [HttpGet]
        public IHttpActionResult GetById([FromUri] Guid ProductID)
        {
            return Ok(_efr.GetById(ProductID));
        }

        [Route("DeleteProduct/{ProductID}")]
        [HttpGet]
        public IHttpActionResult DeleteProduct([FromUri] Guid ProductID)
        {
            var countBefore = _efr.CountAll();
            _efr.Delete(ProductID);
            var countAfter = _efr.CountAll();

            return countBefore == countAfter - 1 ? Ok("Product Deleted") : Ok("Product not Found!!");
        }

        [Route("UpdateProduct")]
        [HttpGet]
        public IHttpActionResult Update(Product product)
        {
            _efr.Update(product);
            return Ok("Product Updated");
        }
    }
}
