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
    [RoutePrefix("api/v1/ShoppingCart/WishList")]
    public class WishListController : ApiController
    {
        private EntityFrameworkRepository<WishList> _efr = new EntityFrameworkRepository<WishList>();

        [Route("AddWishList")]
        [HttpPost]
        public IHttpActionResult PostAddProduct(WishList wishlist)
        {
            return Ok(_efr.Add(wishlist));
        }

        [Route("GetWishLists")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_efr.Get());
        }

        [Route("GetWishList/{WishListID}")]
        [HttpGet]
        public IHttpActionResult GetById([FromUri] Guid WishListID)
        {
            return Ok(_efr.GetById(WishListID));
        }

        [Route("WishList/{WishListID}")]
        [HttpGet]
        public IHttpActionResult DeleteLineItemID([FromUri] Guid WishListID)
        {
            var countBefore = _efr.CountAll();
            _efr.Delete(WishListID);
            var countAfter = _efr.CountAll();

            return countBefore == countAfter - 1 ? Ok("Wishlist Deleted") : Ok("Wishlist not Found!!");
        }

        [Route("UpdateWishList")]
        [HttpGet]
        public IHttpActionResult Update(WishList wishlist)
        {
            _efr.Update(wishlist);
            return Ok("Wishlist Updated");
        }
    }
}
