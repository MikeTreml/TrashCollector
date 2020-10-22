using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorProject.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Current Balance")]
        [DefaultValue(0)]
        public double AccountBalance { get; set; }
        [Display(Name = "Pick up day of the week")]
        public DayOfWeek PickUpDay { get; set; }


        // If i have time i would like to create a check box for each day of the week for multiple day options
        //*******************************
        //[Display(Name = "Sun")]
        //public bool Sunday { get; set; }
        //[Display(Name = "Mon")]
        //public bool Monday { get; set; }
        //[Display(Name = "Tues")]
        //public bool Tuesday { get; set; }
        //[Display(Name = "Wed")]
        //public bool Wednesday { get; set; }
        //[Display(Name = "Thurs")]
        //public bool Thursday { get; set; }
        //[Display(Name = "Fri")]
        //public bool Friday { get; set; }
        //[Display(Name = "Sat")]
        //public bool Saturday { get; set; }
        //*******************************
        
        
        [Display(Name = "One Time Pickup")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? OneTimePickUp { get; set; }
       

        [Display(Name = "Suspend Start")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? SuspendStart { get; set; }
        [Display(Name = "Suspend End")]
        [DataType(DataType.Date)]
        public DateTime? SuspendEnd { get; set; }

        //Address table
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        //User Table
        [ForeignKey("IdentityUser")]
        [Display(Name = "Identity User")]
        public string IdentityUserId { get; set; }
        public IdentityUser Identity { get; set; }



    }
}
