﻿using eCommerce.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL
{
    public class eCommerceDb:DbContext
    {

      

        public eCommerceDb(string connectionString)
            :base(connectionString)
        {
           
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}
