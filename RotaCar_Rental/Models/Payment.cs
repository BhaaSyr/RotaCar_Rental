
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;


public class Payment
{
    [Key]
    public int Id { get; set; }


    public int UserID { get; set; }


    public decimal Amount { get; set; }


    public string PaymentMethod { get; set; }

    [Column(TypeName = "Date")]
    public DateTime PaymentDate { get; set; }


    public string Status { get; set; }
}
