using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_SellersTable.Models;

namespace WebApp_SellersTable.Services
{
    public class SellerService
    {
        private readonly WebApp_SellersTableContext _context;

        public SellerService(WebApp_SellersTableContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            seller.Department = _context.Department.First();
            _context.Add(seller);
            _context.SaveChanges();
        }
    }
}
