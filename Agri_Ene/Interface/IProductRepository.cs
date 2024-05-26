using Agri_Ene.Data;
using Agri_Ene.Models;

namespace Agri_Ene.Interface
{

    public interface IProductRepository
    {
        //Get Commands 
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetByFarmer(string farmer);
        Task<IEnumerable<Product>> GetProductsByDateRange(DateTime startDate, DateTime endDate);
        Task<IEnumerable<Product>> GetProdBy_Category(ProductCategories? category);
        //CRUD commands
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(Product product);
        bool Save();


    }
}
