using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorProject.Models
{
    public class JoinCustomerAddress
    {
       
        public Customer CustomerVM { get; set; }
        public Address AddressVM { get; set; }
    }
}
