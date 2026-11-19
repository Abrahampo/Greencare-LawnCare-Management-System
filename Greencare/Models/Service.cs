using System.ComponentModel.DataAnnotations;

namespace Greencare.Models;

public class Service
{
    public int ServiceID { get; set; }

    [Required]
    public string ServiceName { get; set; } = "";

    public string? Description { get; set; }

    public decimal Price { get; set; }
}