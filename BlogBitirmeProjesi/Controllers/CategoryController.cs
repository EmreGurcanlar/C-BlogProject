using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace BlogBitirmeProjesi.Controllers
{
	public class CategoryController : Controller
	{
		CategoryManager cm = new CategoryManager(new EfCategoryDal());
		public IActionResult Index()
		{
			return View();
		}


		public IActionResult GetCategoryList()
		{
			var categoryvalues = cm.GetList();
			return View(categoryvalues);
		}

		[HttpGet]
		public IActionResult AddCategory()
		{
			return View();
		}



		[HttpPost]
		public IActionResult AddCategory(Category p)
		{
			// cm.CategoryAddBl(p);
			CategoryValidator categoryValidatior = new CategoryValidator();
			ValidationResult results = categoryValidatior.Validate(p);
			if (results.IsValid)
			{
				cm.CategoryAdd(p);
				return RedirectToAction("GetCategoryList");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}

			return View();




		}
	}
}
