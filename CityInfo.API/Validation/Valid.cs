using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Models;
using FluentValidation;
using CityInfo.API.ViewModels;

namespace CityInfo.API.Validation
{
    public class Valid : AbstractValidator<ContactViewModel>
    {
        public Valid()
        {
        //    RuleFor(member => member.Boss).NotEmpty().WithMessage("Please specify a Boss name");
        //    RuleFor(member => member.Date).NotEmpty();
        //    RuleFor(mem => mem.Surname).NotEqual(customer => customer.Forename);
        //    RuleFor(member => member.Overtime1).NotEmpty().When.Empty(member => member.Overtime2);
        //    RuleFor(member => member.Member1).NotEmpty();
        //    RuleFor(member => member.Postcode).Must(BeAValidPostcode).WithMessage("Please specify a valid postcode");
        }
    }
}
