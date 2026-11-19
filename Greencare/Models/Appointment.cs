namespace Greencare.Models;

public class Appointment
{
    public int AppointmentID { get; set; }

    public int CustomerID { get; set; }

    public int EmployeeID { get; set; }

    public int ServiceID { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string Status { get; set; } = "";

    public Customer? Customer { get; set; }

    public Employee? Employee { get; set; }

    public Service? Service { get; set; }
}
