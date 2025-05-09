using E_Commerce_WebApplication.Data;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_WebApplication.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _dbContext;
        public CategoryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {

            var objCategoryList = _dbContext.Categories.ToList();  
            return View();
        }
    }
}
