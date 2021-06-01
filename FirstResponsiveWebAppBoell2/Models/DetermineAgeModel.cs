using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//page that updates data and applies business rules, validates data
namespace FirstResponsiveWebAppBoell2.Models
{
    public class DetermineAgeModel
    {
        //attributes
        [Required(ErrorMessage = "Please enter your name.")] // makes name a required field, error message if name isnt entered
        public String Name { get; set; }
        [Required(ErrorMessage ="Please enter a valid date")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        readonly DateTime Now = DateTime.Today;//gets current day and time
        //method to determine your age
        public int? AgeThisYear()
        {
            int age = Now.Year - Birthday.Year;
            
            if (Now.Month < Birthday.Month || (Now.Month == Birthday.Month && Now.Day < Birthday.Day)) {
                age--;
            }
            return age;//returns value
        }
        //method to show what your age will be by December 31, 2021
        public int? AgeThisYear2()
        {
            int age2 = Now.Year - Birthday.Year;

            return age2; //returns value
        }
    }
}