using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class DressValidator : AbstractValidator<Dress>
    {
        public DressValidator()
        {
            RuleFor(p => p.DressName).NotEmpty().WithMessage(Messages.DressNameInvalid);
            RuleFor(p => p.DressName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.DressName).Must(StartWithA);


        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
