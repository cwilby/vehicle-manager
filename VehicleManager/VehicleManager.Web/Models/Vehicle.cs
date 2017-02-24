using System.ComponentModel.DataAnnotations;

namespace VehicleManager.Web.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public ushort Year { get; set; }
        [Required]
        public string Color { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal RRP { get; set; }
        [Required]
        public decimal DiscountAmount { get; set; }
    }
}