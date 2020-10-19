using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorProject.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Display(Name = "Sun")]
        public bool Sunday { get; set; }
        [Display(Name = "Mon")]
        public bool Monday { get; set; }
        [Display(Name = "Tues")]
        public bool Tuesday { get; set; }
        [Display(Name = "Wed")]
        public bool Wednesday { get; set; }
        [Display(Name = "Thurs")]
        public bool Thursday { get; set; }
        [Display(Name = "Fri")]
        public bool Friday { get; set; }
        [Display(Name = "Sat")]
        public bool Saturday { get; set; }

        public string Image { get; set; }

        public double Latitude { get; set; }
        
        public double Longitude { get; set; }


        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }




    }
}
