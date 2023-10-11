using System.Runtime.CompilerServices;

namespace Appointments.Domain;

public class Appointment
{
    public String Title { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int ServiceID { get; set; }
    public int PatientID { get; set; }
    public DateTime Date { get; set; }
    public String Location { get; set; }
    public int StatusID { get; set; }

    public DateTime getDuration()
    {
        TimeSpan duration = this.EndTime.Subtract(this.StartTime);
        return duration;
    }
}