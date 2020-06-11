using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp_SellersTable.Models;

namespace WebApp_SellersTable.Data
{
    public class WebApp_SellersTableContext : DbContext
    {
        public WebApp_SellersTableContext (DbContextOptions<WebApp_SellersTableContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp_SellersTable.Models.Department> Department { get; set; }
    }
}
