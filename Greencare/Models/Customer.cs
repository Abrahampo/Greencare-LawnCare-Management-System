using System.ComponentModel.DataAnnotations;

namespace Greencare.Models;


public class Customer
{
    public int CustomerID { get; set; }

    [Required]
    public string FirstName { get; set; } = "";

    [Required]
    public string LastName { get; set; } = "";

    [Phone]
    public string? Phone { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    public string? Address { get; set; }
}