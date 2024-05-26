using Agri_Ene.Data;
using Agri_Ene.Interface;
using Agri_Ene.Models;
using Agri_Ene.Services;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Agri_Ene.Repository
{
    public class ProductRepository : IProductRepository
    {
        //Private readonly var to access the db 
        private AppDbContext _context;
        private readonly ClaimsPrincipal _currentUser;


        //Must add add all database tanles with the DBContext
        //public ProductRepository(AppDbContext context)
        //{
        //    _context = context;
        //}
        public ProductRepository(AppDbContext context, ClaimsPrincipal currentUser)
        {
            _context = context;
            _currentUser = currentUser;
        }
        public bool Add(Product product)
        {
            // Set the FarmerId property to the current user's ID
            product.FarmerId = _currentUser.FindFirst(ClaimTypes.NameIdentifier)?.Value;
          
            //NOTE CONTEXT.ADD=> ONLY generate ths sql must Save later 
            _context.Add(product);
            //Calling save to send the sql to DB and creating entity
            return Save();
        }

        public bool Delete(Product product)
        {
            _context.Remove(product);
            return Save();
        }

        //returning list 
        public async Task<IEnumerable<Product>> GetAllEmp()
        {
            return await _context.Products.ToListAsync();

        }
         // Return by Farmer
        public async Task<IEnumerable<Product>> GetByFarmer(string farmerName)
        {
            return await _context.Products
              .Include(p => p.Farmer)
              .Where(p => p.Farmer != null && p.Farmer.FirstName == farmerName)
              .ToListAsync();
        }
        public async Task<IEnumerable<Product>> GetAll()
        {
            // Get the current user's ID
            var userId = _currentUser.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            // Filter products by the current user's ID
            return await _context.Products
                .Where(p => p.FarmerId == userId)
                .ToListAsync();
        }

        //Returning one
        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(i => i.prodId == id);
        }
        public async Task<IEnumerable<Product>> GetProductsByDateRange(DateTime startDate, DateTime endDate)
        {
            // Query the database to retrieve products within the specified date range
            return await _context.Products
                .Where(p => p.productionDate >= startDate && p.productionDate <= endDate)
                .ToListAsync();
        }
        public async Task<IEnumerable<Product>> GetProdBy_Category( ProductCategories? category)
        {
            var query = _context.Products.AsQueryable();


            if (category.HasValue)
            {
                query = query.Where(p => p.prodCategory == category.Value);
            }

            return await query.ToListAsync();
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            // Returns true if changes were saved( greater than 0) successfully, otherwise false
            return saved > 0 ? true : false;
        }

        public bool Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
