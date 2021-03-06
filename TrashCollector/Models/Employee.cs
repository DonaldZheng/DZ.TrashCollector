using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId
        {
            get; set;
        }
        
        public string FirstName
        {
            get; set;
        }
   
        public string LastName
        {
            get; set;
        }
        
        public string Zipcode
        {
            get; set; 
        }
        
        public DateTime? SelectedDatePickUp
        {
            get; set;
        }
        [ForeignKey("IdentityUser")]
        public string IdentityUserId
        {
            get; set;
        }
        public IdentityUser IdentityUser
        {
            get; set;
        }

    }
}
