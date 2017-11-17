using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Validation
{
    public class ifOther: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return (String)value != "Other";                       
        }
    }
}
