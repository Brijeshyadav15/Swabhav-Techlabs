using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoppingCore.Entity_Framework.Repository;
using ShoppingCore.Models;
using System.Web.Http.Cors;

namespace ShoppingCartAPI.Controllers
{
    [RoutePrefix("api/v1/ShoppingCart/Product")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
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

            if (countBefore - 1 == countAfter)
                return Ok("Product Deleted");
            else
                return Ok("Product not Found!!");
        }

        [Route("UpdateProduct")]
        [HttpPost]
        public IHttpActionResult Update(Product product)
        {
            _efr.Update(product);
            return Ok("Product Updated");
        }
    }
}
