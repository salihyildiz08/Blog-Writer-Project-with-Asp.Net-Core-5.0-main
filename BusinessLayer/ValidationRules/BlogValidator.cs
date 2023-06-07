using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator() 
        {
            RuleFor(x=>x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçmeyiniz");
            RuleFor(x=>x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş geçmeyiniz");
            RuleFor(x=>x.BlogImage).NotEmpty().WithMessage("Blog görsel boş geçmeyiniz");
            RuleFor(x=>x.BlogTitle).MaximumLength(150).WithMessage("Blog 150 karakterden daha az veri girişi yapınız.");
            RuleFor(x=>x.BlogTitle).MinimumLength(5).WithMessage("Blog 5 karakterden daha fazla veri girişi yapınız.");
        }
    }
}
