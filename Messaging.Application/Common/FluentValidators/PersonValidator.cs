using FluentValidation;
using Messaging.Application.CQRS.Person.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Application.Common.FluentValidators
{
    public class PersonValidator : AbstractValidator<PersonCommand>
    {
        public PersonValidator()
        {
            RuleFor(r => r.FirstName).NotEmpty().WithMessage("FirstName is required")
                .MaximumLength(60).WithMessage("FirstName can't exceed 60 characters");

            RuleFor(r=> r.LastName).NotEmpty().WithMessage("LastName is required")
                .MaximumLength(60).WithMessage("LastName can't exceed 60 characters");
        }
    }
}
