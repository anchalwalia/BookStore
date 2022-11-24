using AnchalsBooks.DatacAccess.Repository.IRepository;
using AnchalsBooks.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnchalsBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id) //action method for upsert
        {
            Category category = new Category();  // using AnchalsBooks.Models;
            if (id == null)
            {
                //this is for create
                return View(category);
            }
            //this is for edit
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        //use HTTP Post to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(Category Category)
        {
            if (ModelState.IsValid)    //checks all validations in the modelto increase security
            {
                if (Category.Id == 0)
                {
                    _unitOfWork.Category.Add(Category);
                }
                else
                {
                    _unitOfWork.Category.Update(Category);
                }
                _unitOfWork.save();
                return RedirectToAction(nameof(Index));    //to see all categories
            }
            return View(Category);
        }


        //API calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()

        {
            //return NotFound();
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.save();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}

