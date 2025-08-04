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
            var objFromDb = _dbContext.Products.FirstOrDefault(u => u.Id == obj.Id);

            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title; 
                objFromDb.Description = obj.Description; 
                objFromDb.ISBN = obj.ISBN; 
                objFromDb.Author = obj.Author; 
                objFromDb.ListPrice = obj.ListPrice; 
                objFromDb.Price = obj.Price; 
                objFromDb.Price50 = obj.Price50;
                objFromDb.Price100 = obj.Price100; 
                objFromDb.CategoryId = obj.CategoryId;
                
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }

            }

        }
    }
}
