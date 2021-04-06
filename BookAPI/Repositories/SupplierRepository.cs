using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookAPI.Data;
using BookAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Repositories
{
    public interface ISupplierRepository
    {
        Task<List<Supplier>> GetSuppliers();
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

    }
}
