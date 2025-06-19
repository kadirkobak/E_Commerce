using E_Commerce.DataAccessLayer.Repository.IRepository;
using E_Commerce.Models;
using E_Commerce_DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccessLayer.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
      
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }



        public void Update(Product obj)
        {
            _dbContext.Products.Update(obj);
        }
    }
}
