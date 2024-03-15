using System.ComponentModel.DataAnnotations;

namespace WareHouse.Models;

public class Group
{
    [Key]//id -> primary key //int -> autonumber
    public int Id { get; set; }

    [Required]//title is required
    public string Title { get; set; }

    virtual public List<Product>? Products { get; set; }
}
