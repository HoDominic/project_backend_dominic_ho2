using System;
using BookAPI.Data;

namespace BookAPI.Repositories
{
    public class SupplierRepository
    {
        private IRegistrationContext _context;
        public SupplierRepository(IRegistrationContext context)
        {
            _context = context;
        }
    }
}
