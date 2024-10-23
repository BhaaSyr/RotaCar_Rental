

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Review
    {
    [Key]
    public int Id { get; set; }


        public int UserId { get; set; }


    public int CarID { get; set; }
    [ForeignKey("CarID")]
    public Car car { get; set; }


    public DateTime ReviewDate { get; set; }

        public string? Comment { get; set; }


        public int Rate { get; set; }
    }

