﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using SportsStore.Domain;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
