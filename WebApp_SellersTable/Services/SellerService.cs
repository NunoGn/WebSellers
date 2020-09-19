using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_SellersTable.Models;
using Microsoft.EntityFrameworkCore;
using WebApp_SellersTable.Services.Exceptions;

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
            _context.Add(seller);
            _context.SaveChanges();
        }
        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
        public void Update(Seller seller)
        {
            if (!_context.Seller.Any(x => x.Id == seller.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(seller);
                _context.SaveChanges();
            }
          catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
