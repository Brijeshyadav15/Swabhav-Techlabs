﻿using ShoppingCore.Entity_Framework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCore.Models
{
    public class WishList : Entity
    {
        public WishList()
        {
        }

        public WishList(Guid id, Guid customerid, string name)
        {
            Id = id;
            CustomerId = customerid;
            Name = name;
        }

        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public List<LineItem> LineItems { get; set; }
    }
}
