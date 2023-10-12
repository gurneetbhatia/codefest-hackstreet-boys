namespace Domain.Interfaces;

public interface IPersonRepository
{
    //int UpdatePatientDetails(Patient patient);

    Patient GetPatient(string email);

    Employee GetEmployee(string email);
}
