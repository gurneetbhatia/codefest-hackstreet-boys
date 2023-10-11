using Newtonsoft.Json.Linq;

namespace Domain.Interfaces;

public interface IAppointmentsRepository
{
    List<Appointment> Get(int apptId);
    int Update(int apptId, JObject jsonObject);
}
