
using System.ComponentModel.DataAnnotations;

namespace SqliteApp.Models;

public class Person
{
    [Key]//auto number
    public int Id { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }
    public int Age { get; set; }
}
