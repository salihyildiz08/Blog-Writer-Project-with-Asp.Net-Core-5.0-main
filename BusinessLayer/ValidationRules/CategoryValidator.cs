﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("You cannot leave the category name blank.");
            RuleFor(x=>x.CategoryDescription).NotEmpty().WithMessage("You cannot leave the category description blank.");
            RuleFor(x=>x.CategoryName).MaximumLength(50).WithMessage("Category name must be no more than 50 characters");
            RuleFor(x=>x.CategoryName).MinimumLength(2).WithMessage("Category name must be at least 2 characters");
        }
    }
}
