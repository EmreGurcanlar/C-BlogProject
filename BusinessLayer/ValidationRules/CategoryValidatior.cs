using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class CategoryValidator:AbstractValidator<Category>
	{
		public CategoryValidator()
		{
			RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz!");
			RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı Boş Geçemezsiniz!");
			RuleFor(x => x.CategoryName).MaximumLength(3).WithMessage("Lütfen En Az 3 Karakter Giriş Yapın.");
			RuleFor(x => x.CategoryName).MaximumLength(25).WithMessage("Lütfen En Fazla 25 Karakter Giriş yapın");
		}
	}
}
