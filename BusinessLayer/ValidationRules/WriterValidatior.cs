using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidatior : AbstractValidator<Writer>
	{
		public WriterValidatior()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz!");
			RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz!");
			RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında Kısmını	 Boş Geçemezsiniz!");
			RuleFor(x => x.WriterName).MaximumLength(2).WithMessage("Lütfen En Az 2 Karakter Giriş Yapın.");
			RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Lütfen En Fazla 50 Karakter Giriş yapın");
		}
	}
}
