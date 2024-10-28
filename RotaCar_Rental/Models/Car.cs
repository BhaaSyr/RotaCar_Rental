
using RotaCar_Rental.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Car
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "The number plate is required to identify the vehicle")]
    public string Make { get; set; }


    public string Model { get; set; }

    [Required(ErrorMessage = "The year is required to identify the vehicle")]
    public int Year { get; set; }

    public int? Mileage { get; set; }


    public int Seats { get; set; }

    public string Type { get; set; }

    public string? ImageUrl { get; set; }


    public string Fuel { get; set; }


    public string Transmission { get; set; }

    [Required(ErrorMessage = "The number plate is required to identify the vehicle")]
    [Display(Name = "License Plate")]
    public string? LicensePlate { get; set; }

    public int LocationID { get; set; }
    [ForeignKey("LocationID")]
    public Location location { get; set; }


    public decimal RentalRateDaily { get; set; }


    public decimal RentalRateWeekly { get; set; }


    public string Status { get; set; }


    public List<Feature>? Features { get; set; } = new List<Feature>();


    public List<MaintenanceHistory>? MaintenanceHistory { get; set; } = new List<MaintenanceHistory>();
	public List<Review>? Reviews { get; set; } = new List<Review>();
}




