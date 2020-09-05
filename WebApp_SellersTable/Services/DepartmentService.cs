using System.Linq;
using WebApp_SellersTable.Models;
using System.Collections.Generic;

namespace WebApp_SellersTable.Services
{
    public class DepartmentService
    {
        private readonly WebApp_SellersTableContext _context;

        public DepartmentService(WebApp_SellersTableContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
   
}
