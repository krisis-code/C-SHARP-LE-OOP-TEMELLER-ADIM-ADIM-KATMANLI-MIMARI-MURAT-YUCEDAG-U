using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Müşteri ismi boş geçilemez !!!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Müşteri ismi min 3 karakter olmak zorunda !!!");


            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir bilgisi  boş geçilemez !!!");
            

        }
    }
}
