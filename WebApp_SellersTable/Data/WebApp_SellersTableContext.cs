using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp_SellersTable.Models;

namespace WebApp_SellersTable.Models
{
    public class WebApp_SellersTableContext : DbContext
    {
        public WebApp_SellersTableContext (DbContextOptions<WebApp_SellersTableContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
   
    }
}
