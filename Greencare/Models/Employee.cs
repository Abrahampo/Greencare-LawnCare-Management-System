using System.ComponentModel.DataAnnotations;

namespace Greencare.Models;

public class Employee
{
    public int EmployeeID { get; set; }

    [Required]
    public string FirstName { get; set; } = "";

    [Required]
    public string LastName { get; set; } = "";

    public string? Phone { get; set; }

    public string? Position { get; set; }
}