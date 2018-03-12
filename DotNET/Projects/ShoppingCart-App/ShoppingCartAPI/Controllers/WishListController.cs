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
    [RoutePrefix("api/v1/ShoppingCart/User/{UserId}/WishList")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class WishListController : ApiController
    {
        private EntityFrameworkRepository<WishList> _efr = new EntityFrameworkRepository<WishList>();

        [Route("AddWishList")]
        [HttpPost]
        public IHttpActionResult PostAddWishList(WishList wishlist)
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

        [Route("DeleteWishList/{WishListID}")]
        [HttpGet]
        public IHttpActionResult DeleteLineItem([FromUri] Guid WishListID)
        {
            var countBefore = _efr.CountAll();
            _efr.Delete(WishListID);
            var countAfter = _efr.CountAll();

            if (countBefore - 1 == countAfter)
                return Ok("WishList Deleted");
            else
                return Ok("WishList not Found!!");
        }

        [Route("UpdateWishList")]
        [HttpPost]
        public IHttpActionResult Update(WishList wishlist)
        {
            _efr.Update(wishlist);
            return Ok("Wishlist Updated");
        }
    }
}
