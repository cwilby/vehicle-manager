using System.ComponentModel.DataAnnotations;

namespace VehicleManagerClean.Core.Domain
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        public int Year { get; set; }
        [Required]
        public string Color { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal RRP { get; set; }
        public decimal Discount { get; set; }
    }
}