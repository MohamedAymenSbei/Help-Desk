namespace HelpDesk.Models;

public class Complaint
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Status { get; set; } // possible values: "Not yet processed", "In progress", "Resolved", "No solution"
    public string Solution { get; set; } // corrective actions taken by the technician
    public User User { get; set; } // navigation property to the user who created the complaint
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? ClosedAt { get; set; }
}