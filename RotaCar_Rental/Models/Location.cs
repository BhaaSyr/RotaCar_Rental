


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Location
{
    [Key]
    public int Id { get; set; }


    public string Name { get; set; }


    public string Street { get; set; }


    public string City { get; set; }


    public string State { get; set; }


    public string Zip { get; set; }
	public double Long {  get; set; }
	public double Lat { get; set; }
    public int AvailableCar { get; set; }
    [DataType(DataType.PhoneNumber)]
    [Required]
    public string Phone { get; set; }


  
}




