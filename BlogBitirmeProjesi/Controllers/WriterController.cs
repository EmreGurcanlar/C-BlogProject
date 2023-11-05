using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace BlogBitirmeProjesi.Controllers
{
	public class WriterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterDal());
		public IActionResult Index()
		{
			var WriterValues = wm.GetList();
			return View(WriterValues);
		}

		[HttpGet]
		public IActionResult AddWriter() 
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddWriter(Writer p)
		{
			WriterValidatior writervalidator= new WriterValidatior();
			ValidationResult results=writervalidator.Validate(p);
			if (results.IsValid)
			{
				wm.WriterAdd(p);
				return RedirectToAction("Index");
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
