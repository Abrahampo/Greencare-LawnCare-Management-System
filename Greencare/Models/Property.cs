namespace Greencare.Models;

public class Property
{
    public int PropertyID { get; set; }

    public int CustomerID { get; set; }

    public string StreetAddress { get; set; } = "";

    public string City { get; set; } = "";

    public string State { get; set; } = "";

    public string ZipCode { get; set; } = "";

    public double LotSize { get; set; }

    public Customer? Customer { get; set; }
}