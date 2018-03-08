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
    [RoutePrefix("api/v1/ShoppingCart/ProductCategory")]
    public class ProductCategoryController : ApiController
    {
        private EntityFrameworkRepository<ProductCategory> _efr = new EntityFrameworkRepository<ProductCategory>();

        [Route("AddProductCategory")]
        [HttpPost]
        public IHttpActionResult PostAddProduct(ProductCategory productCategory)
        {
            return Ok(_efr.Add(productCategory));
        }

        [Route("GetProductCategories")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_efr.Get());
        }

        [Route("GetProductCategory/{ProductCategoryID}")]
        [HttpGet]
        public IHttpActionResult GetById([FromUri] Guid ProductCategoryID)
        {
            return Ok(_efr.GetById(ProductCategoryID));
        }

        [Route("DeleteProductCategoryID/{ProductCategoryID}")]
        [HttpGet]
        public IHttpActionResult DeleteLineItemID([FromUri] Guid ProductCategoryID)
        {
            var countBefore = _efr.CountAll();
            _efr.Delete(ProductCategoryID);
            var countAfter = _efr.CountAll();

            return countBefore == countAfter - 1 ? Ok("LineItem Deleted") : Ok("LineItem not Found!!");
        }

        [Route("UpdateProductCategory")]
        [HttpGet]
        public IHttpActionResult Update(ProductCategory productcategory)
        {
            _efr.Update(productcategory);
            return Ok("Product Updated");
        }
    }
}
