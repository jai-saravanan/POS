using Persistance;
using Repository.Interface;
using System.Linq;

namespace Repository.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private POSDbContext _dbContext;
        public ProductRepository(POSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Product> GetProducts()
        {
            return _dbContext.Products.AsQueryable();
        }

        public Product GetProductsDetailById()
        {
            return _dbContext.Products.Include("Product_OpeningStock").FirstOrDefault();
        }
    }
}
