using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRental.Model
{
    public class Rental
    {
        public int RentalId { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public int BikeId { get; set; }
        public Bike Bike { get; set; }

        [Required]
        public DateTime RentalBegin { get; set; }

        public DateTime RentalEnd { get; set; }

        [Required]
        [Range(0.00, Double.MaxValue)]
        [RegularExpression(@"\d.\d{2}", ErrorMessage = "Please Enter a price with 2 decimals")]
        public decimal totalCost { get; set; }

        public Boolean PaidFlag { get; set; }

    }
}
