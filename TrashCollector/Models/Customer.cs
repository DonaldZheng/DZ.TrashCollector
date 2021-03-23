using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId
        {
            get; set;
        }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is a Required Input")]
        public string FirstName
        {
            get; set;
        }

        [Display(Name = "Last Name")]
        public string LastName
        {
            get; set;
        }

        [Display(Name = "StreetName")]
        public string StreetName
        {
            get; set;
        }

        [Display(Name = "City")]
        public string City
        {
            get; set;
        }
        [Display(Name = "ZipCode")]
        public string ZipCode
        {
            get; set;
        }
        [Display(Name = "Confirm Pick Up")]
        public string ConfirmPickUp
        {
            get; set; 
        }


        [Display(Name = "Weekly Pickup Day")]
        public string PickUpDay
        {
            get; set;
        }

        [Display(Name = "Request Extra One Time Pickup")]
        public DateTime? OneTimePickUp
        {
            get; set;
        }

        [Display(Name = "Suspend Start Date (Optional)")]
        public DateTime? SuspendStartDate
        {
            get; set;
        }

        [Display(Name = "Suspend End Date: (Optional)")]
        public DateTime? SuspendEndDate
        {
            get; set;
        }

        [Display(Name = "Balance Due")]
        public int BalanceDue
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
