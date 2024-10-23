using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotaCar_Rental.Models
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }
        public int CarID { get; set; }
        [ForeignKey("CarID")]
        public Car Car { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

    }
}
