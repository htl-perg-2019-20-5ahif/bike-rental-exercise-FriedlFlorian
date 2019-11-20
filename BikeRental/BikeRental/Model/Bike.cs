using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRental.Model
{
    public enum BikeCategory { StandardBike, Mountainbike, TreckingBike, RacingBike }

    public class Bike
    {
        public int BikeId { get; set; }

        [Required]
        [MaxLength(25)]
        public String Brand { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        [MaxLength(1000)]
        public String Notes { get; set; }

        public DateTime LastService { get; set; }

        [Required]
        [Range(0.00, Double.MaxValue)]
        [RegularExpression(@"\d.\d{2}", ErrorMessage = "Please Enter a price with 2 decimals")]
        public decimal RentalPriceFirstHour { get; set; }

        [Required]
        [Range(1.00, Double.MaxValue)]
        [RegularExpression(@"\d.\d{2}", ErrorMessage = "Please Enter a price with 2 decimals")]
        public decimal RentalPriceAdditionalHour { get; set; }

        public BikeCategory BikeCategory { get; set; }
    }
}
