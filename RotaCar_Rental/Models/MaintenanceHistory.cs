using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotaCar_Rental.Models
{
    public class MaintenanceHistory
    {
        [Key]
        public int Id { get; set; }
        public int CarID { get; set; }
        [ForeignKey("CarID")]
        public Car Car { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

        public string Details { get; set; }
    }
}
