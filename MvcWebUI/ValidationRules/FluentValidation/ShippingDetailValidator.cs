using FluentValidation;
using MvcWebUI.Models;
using System;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator:AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(s => s.Firstname).NotEmpty().WithMessage("boş geçilemez");
            RuleFor(s => s.Firstname).MaximumLength(20);
            RuleFor(s => s.Firstname).MinimumLength(20);
            RuleFor(s => s.Address).NotEmpty();
            RuleFor(s => s.Address).NotEmpty();

            RuleFor(s => s.City).NotEmpty().When(s => s.Age < 18);

            //RuleFor(s => s.Firstname); /*.Must();*/
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");

        //}
    }
}