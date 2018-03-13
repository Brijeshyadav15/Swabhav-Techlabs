using ShoppingCore.Entity_Framework.Repository;
using ShoppingCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ShoppingCartAPI.Controllers
{
    [RoutePrefix("api/v1/ShoppingCart/ProductCategory")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProductCategoryController : ApiController
    {
        private EntityFrameworkRepository<ProductCategory> _efr = new EntityFrameworkRepository<ProductCategory>();

        [Route("AddProductCategory")]
        [HttpPost]
        public IHttpActionResult PostAddProductCategory(ProductCategory productCategory)
        {
            return Ok(_efr.Add(productCategory));
        }

        [Route("GetProductCategoryCount")]
        [HttpGet]
        public IHttpActionResult GetProductCategoryCount()
        {
            return Ok(_efr.CountAll());
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

        [Route("DeleteProductCategory/{ProductCategoryID}")]
        [HttpGet]
        public IHttpActionResult DeleteProductCategory([FromUri] Guid ProductCategoryID)
        {
            var countBefore = _efr.CountAll();
            _efr.Delete(ProductCategoryID);
            var countAfter = _efr.CountAll();

            if (countBefore - 1 == countAfter)
                return Ok("ProductCategory Deleted");
            else
                return Ok("ProductCategory not Found!!");
        }

        [Route("UpdateProductCategory")]
        [HttpPost]
        public IHttpActionResult Update(ProductCategory productcategory)
        {
            _efr.Update(productcategory);
            return Ok("Product Updated");
        }
    }
}
