using E_Commerce_DataAccessLayer.Data;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using E_Commerce.DataAccessLayer.Repository.IRepository;

namespace E_Commerce_WebApplication.Controllers
{
    public class CategoryController : Controller
    {

        private readonly IUnitOfWork _unityOfWork;
       
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unityOfWork = unitOfWork;
        }

        public IActionResult Index()
        {

            var objCategoryList = _unityOfWork.Category.GetAll().ToList();
            return View(objCategoryList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _unityOfWork.Category.Add(obj);
                _unityOfWork.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }

            return View();

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category categoryFromDb = _unityOfWork.Category.Get(u => u.Id == id);   

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _unityOfWork.Category.Update(obj);
                _unityOfWork.Save();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }

            return View();

        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            Category categoryFromDb = _unityOfWork.Category.Get(u => u.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            Category? categoryFromDb = _unityOfWork.Category.Get(u => u.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            _unityOfWork.Category.Remove(categoryFromDb);
            _unityOfWork.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
