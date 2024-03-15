using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WareHouse.Models;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid Id { get; set; }
    public int GroupId { get; set; }//Id in group is integer
    public string Name { get; set; }
    public string? Description { get; set; }//string? -> nullable
    public string? Img { get; set; }
    public int Inventory { get; set; } = 1;//default value -> 1

    [ForeignKey(nameof(GroupId))]
    virtual public Group? Group { get; set; }

}
