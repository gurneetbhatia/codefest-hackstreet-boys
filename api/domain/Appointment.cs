namespace Domain;
public class Appointment
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Service { get; set; }
    public int PatientID { get; set; }
    public int TherapistId { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public string Status { get; set; }

    public TimeSpan GetDuration()
    {
        return EndTime.Subtract(StartTime);
    }

}
