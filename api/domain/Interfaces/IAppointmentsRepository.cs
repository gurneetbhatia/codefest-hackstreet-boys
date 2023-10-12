namespace Domain.Interfaces;

public interface IAppointmentsRepository
{
    List<Appointment> Get(string patientId, string therapistId);
    int Update(Appointment appointment);
}
