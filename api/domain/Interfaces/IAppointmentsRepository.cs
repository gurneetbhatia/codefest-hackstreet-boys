namespace Domain.Interfaces;

public interface IAppointmentsRepository
{
    List<Appointment> Get(int? patientId, int? therapistId);
    int Update(Appointment appointment);
}
