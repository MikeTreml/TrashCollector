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
        [Required]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        //extra feature to add a picture of the address from google maps if possible. 
        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }




    }
}
