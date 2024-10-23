
using RotaCar_Rental.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Rental
{
    [Key]
    public int Id { get; set; }



    public int UserID { get; set; }
	//[ForeignKey("UserID")]
	//public AppUser user { get; set; }


	public int CarID { get; set; }
    [ForeignKey("CarID")]
    public Car car { get; set; }


    [Column(TypeName = "Date")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "Date")]

    public DateTime EndDate { get; set; }

    public string Status { get; set; }


    public decimal TotalAmount { get; set; }


    public int PaymentID { get; set; }
    [ForeignKey("PaymentID")]
    public Payment payment { get; set; }
}
