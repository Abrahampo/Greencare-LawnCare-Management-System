namespace Greencare.Models;

public class Invoice
{
    public int InvoiceID { get; set; }

    public int AppointmentID { get; set; }

    public Appointment? Appointment { get; set; }

    public DateTime InvoiceDate { get; set; }

    public decimal TotalAmount { get; set; }

    public string PaymentStatus { get; set; } = "";
}