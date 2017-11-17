using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

using CityInfo.API.ViewModels;


namespace CityInfo.API.Validation
{
    public class AtLeastOneField : ValidationAttribute
    {
        string member;
        public AtLeastOneField(String member2)
        {
            member = member2;
        }

         public override bool IsValid(object value){
                return member == null;
         }
    }
            
        
}
        // Have to override IsValid
    //    public override bool IsValid(object value)
    //    {
    //        if (value != null)
    //        {
    //            ContactViewModel model = (ContactViewModel)value;
    //            if (string.IsNullOrEmpty(model.Member1) && string.IsNullOrEmpty(model.Member2))
    //            {
    //                return false;
    //                //var validationMessage = "Please provide at least one member.";
    //                //ModelState.AddModelError("Member1", validationMessage);
    //                // ModelState.AddModelError("Member2", validationMessage);
    //            }

    //            //  Need to use reflection to get properties of "value"...
    //            var typeInfo = value.GetType();

    //            var propertyInfo = typeInfo.GetProperties();

    //            foreach (var property in propertyInfo)
    //            {
    //                if (null != property.GetValue(value, null))
    //                {
    //                    // We've found a property with a value
    //                    return true;
    //                }
    //            }
    //        }
    //        //All properties were null.
    //        return false;
    //    }
    //}

