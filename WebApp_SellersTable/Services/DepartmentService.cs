using System.Linq;
using WebApp_SellersTable.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApp_SellersTable.Services
{
    public class DepartmentService
    {
        private readonly WebApp_SellersTableContext _context;

        public DepartmentService(WebApp_SellersTableContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
   
}
