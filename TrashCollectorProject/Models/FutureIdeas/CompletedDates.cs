using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorProject.Models
{
    public class CompletedDates
    {

        [Key]
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }


        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
