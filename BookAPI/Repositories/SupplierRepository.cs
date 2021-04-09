using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI.Data;
using BookAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Repositories
{
    public interface ISupplierRepository
    {
        Task<List<Supplier>> GetSuppliers();
        Task<Supplier> GetSupplier(int supplierId);
    }

    public class SupplierRepository : ISupplierRepository
    {
        private IRegistrationContext _context;
        public SupplierRepository(IRegistrationContext context)
        {
            _context = context;
        }


        public async Task<List<Supplier>> GetSuppliers()
        {
            try
            {
                return await _context.Suppliers.ToListAsync();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }


        public async Task<Supplier> GetSupplier(int supplierId)
        {
            return await _context.Suppliers.Where(s => s.SupplierId == supplierId).SingleOrDefaultAsync();
        }

    }
}
