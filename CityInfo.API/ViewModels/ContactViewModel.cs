using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using CityInfo.API.Validation;
using CityInfo.API.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CityInfo.API.ViewModels
{
    
    public class ContactViewModel
    {
        [Required(ErrorMessage ="Please provide name of the Boss")]
        [MinLength(5)]
        public string Boss { get; set; }
        
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string Member1 { get; set; }

        [Required(ErrorMessage = "At least one member info is required")]
        public string Name1 { get; set; }

         [Required(ErrorMessage = "At least one member info is required")]
        public int Over1 { get; set; }
        
        public string Member2 { get; set; }    
        public string Name2 { get; set; }
        [CreditCard]
        public int? Over2 { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }    
        
        [Required]        
        [DateRangeFromToday(7)]
        public DateTime? Date { get; set; }       

        [StringLength(100, ErrorMessage = "The {0} is too long. {1} characters is a maximum length.")]        
        public string Comment { get; set; }        
        public string Reason { get; set; }



    }
}
