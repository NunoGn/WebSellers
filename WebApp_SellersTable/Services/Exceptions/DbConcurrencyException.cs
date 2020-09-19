using System;

namespace WebApp_SellersTable.Services.Exceptions
{
    public class DbConcurrencyException:ApplicationException
    {
        public DbConcurrencyException(string message) : base(message)
        {

        }
    }
}
